using MonaLisa.Patterns;
using System;
using System.CommandLine;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace MonaLisa
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {            
            var inputImageFilePath = new Option<string>
                ("--input_image_file_path", "The path of the image(.png) file.");
            var outputDirectoryPath = new Option<string>
                ("--output_directory_path", "The directory path for the output image file.");
            var patternOption = new Option<string>
                ("--pattern",
                "The patterns that will be generated.")
                    .FromAmong("ellipse", "triangle", "rectangle", "mix_pattern");

            var rootCommand = new RootCommand(
                "Approximate an image by continuously generating random colored patterns(ellipses, rectangles, triangles).");
            rootCommand.Add(inputImageFilePath);
            rootCommand.Add(outputDirectoryPath);
            rootCommand.Add(patternOption);
            
            rootCommand.SetHandler((string inputImageFilePath, string outputDirectoryPath, string patternOption) =>
            {
                if (!IsValidInputPath(inputImageFilePath))
                {
                    Console.WriteLine("Please enter the correct path of the image(.png) file.");
                }
                else if (!IsValidOutputPath(outputDirectoryPath))
                {
                    Console.WriteLine("Please enter the correct path for the output image file.");
                }
                else
                {
                    run(inputImageFilePath, outputDirectoryPath, patternOption);
                }
            },
            inputImageFilePath, outputDirectoryPath, patternOption);
            
            rootCommand.Invoke(args);
        }

        static void run(string inputImageFilePath, string outputDirectoryPath, string patternOption)
        {
            Bitmap originalImage = new Bitmap(inputImageFilePath);
            Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(resultImage)) { g.Clear(Color.White); }
            const int TARGET_EFFECTIVE_COUNT = 5000;
            ulong initialSSD = GetSSD(originalImage, resultImage);
            int totalCount = 0;
            int effectiveCount = 0;
            ulong oldSSD = GetSSD(originalImage, resultImage);

            while (effectiveCount < TARGET_EFFECTIVE_COUNT)
            {
                Pattern pattern;
                if (patternOption == "ellipse")
                {
                    pattern = new ColoredEllipse(originalImage.Width, originalImage.Height, GetRandomColor());
                }
                else if (patternOption == "triangle")
                {
                    pattern = new ColoredTriangle(originalImage.Width, originalImage.Height, GetRandomColor());
                }
                else if (patternOption == "rectangle")
                {
                    pattern = new ColoredRectangle(originalImage.Width, originalImage.Height, GetRandomColor());
                }
                else
                {
                    pattern = GetRandomPattern(originalImage.Width, originalImage.Height);
                }

                Bitmap imageWithNewPattern = pattern.AddToImage(resultImage);
                ulong newSSD = GetSSD(originalImage, imageWithNewPattern);
                if (newSSD < oldSSD)
                {
                    resultImage = imageWithNewPattern;
                    oldSSD = newSSD;
                    effectiveCount++;
                    if (effectiveCount % 100 == 0)
                    {
                        string fileName = string.Format("Image{0}.png", effectiveCount / 100);
                        string path = Path.Combine(outputDirectoryPath, fileName);
                        resultImage.Save(path);
                        double similarity = (1.0 * initialSSD - oldSSD) / initialSSD;
                        Console.WriteLine("Total: " + totalCount.ToString()
                            + "; Effective: " + effectiveCount.ToString() 
                            + "; Similarity: " + similarity.ToString("P1", CultureInfo.InvariantCulture)
                            + $"; The maze has been saved in {path}.");                       
                    }
                }
                totalCount++;
            }
        }

        static bool IsValidInputPath(string path)
        {
            if (File.Exists(path) && Path.GetExtension(path) == ".png")
            {
                return true;
            }
            return false;
        }

        static bool IsValidOutputPath(string path)
        {
            return Directory.Exists(path);
        }

        static Pattern GetRandomPattern(int width, int height)
        {
            int caseSwitch = rand.Next(3);
            if (caseSwitch == 0)
            {
                ColoredRectangle pattern = new ColoredRectangle(width, height, GetRandomColor());
                return pattern;
            }
            else if (caseSwitch == 1)
            {
                ColoredTriangle pattern = new ColoredTriangle(width, height, GetRandomColor());
                return pattern;
            }
            else
            {
                ColoredEllipse pattern = new ColoredEllipse(width, height, GetRandomColor());
                return pattern;
            }
        }

        static Color GetRandomColor()
        {
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256), rand.Next(256));
            return randomColor;
        }

        // Calculate Sum of Squared Deviations between two bitmaps.
        static ulong GetSSD(Bitmap bitmap0, Bitmap bitmap1)
        {
            ulong result = 0;
            for (int i = 0; i < bitmap0.Width; i++)
            {
                for (int j = 0; j < bitmap0.Height; j++)
                {
                    Color pixel0 = bitmap0.GetPixel(i, j);
                    Color pixel1 = bitmap1.GetPixel(i, j);
                    ulong a0 = pixel0.A;
                    ulong a1 = pixel1.A;
                    ulong r0 = pixel0.R;
                    ulong r1 = pixel1.R;
                    ulong b0 = pixel0.B;
                    ulong b1 = pixel1.B;
                    ulong g0 = pixel0.G;
                    ulong g1 = pixel1.G;
                    ulong a_diff = a0 - a1;
                    ulong r_diff = r0 - r1;
                    ulong b_diff = b0 - b1;
                    ulong g_diff = g0 - g1;
                    result += a_diff * a_diff + r_diff * r_diff + b_diff * b_diff + g_diff * g_diff;
                }
            }
            return result;
        }
    }
}
