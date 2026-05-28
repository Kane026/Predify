using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Spectre.Console;

namespace Predify
{
    public class PlaySong
    {
        public void Play()
        {
            AnsiConsole.Progress()
                .Columns(
                    new SpinnerColumn(),
                    new TaskDescriptionColumn(),
                    new ProgressBarColumn(),
                    new ElapsedTimeColumn()
                )
                .Start(ctx =>
                {
                    var playSong = ctx.AddTask("Playing song", maxValue: 1000);

                    while (!ctx.IsFinished)
                    {
                        playSong.Increment(1);
                        Thread.Sleep(50);
                    }
                });


                AnsiConsole.MarkupLine("[green]The song has finished playing![/]");
        }
    } }
