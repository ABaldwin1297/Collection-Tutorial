

var frames = new List<int>();

var rnd = new Random();

var highScore = 200;
var total = 0;
var games = 0;

while(total < highScore) {
    frames.Clear();
    total = 0;
    games++;
    for (var idx = 1; idx <= 10; idx++) {
        var score = rnd.Next(31);
        frames.Add(score);
    }
    foreach (var frame in frames) {
        total = total + frame;
    }
}

Console.WriteLine($"{total} took {games} games");