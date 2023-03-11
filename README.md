# CBB Learn 🏀📚

This is my attempt at creating a regression model that predicts college basketball scores.

_Full disclosure: I'm not a data scientist, if that wasn't clear by looking at the code and results_ 🙃 _._

## Training data

I used every game (with recorded stats) from the 2022 regular season NCAA men's basketball season. All statistics were pulled from public ESPN APIs.

Most of the fields are raw, such as `fieldGoalsAttempted`, but there are some fields that are derived e.g. `scoringEfficiency`.

## Model

I used [`ML.NET`](https://dotnet.microsoft.com/en-us/learn/ml-dotnet) to generate and train the model.

The model runs two simulations given two teams, `A` and `B`:

1. Predict the number of points team `A` would score if team `A` was the away team and team `B` was the home team.
2. Predict the number of points team `B` would score if team `B` was the away team and team `A` was the home team.

Given these two point totals, we can predict the game spread.

## Usage

From the top-level directory, you can run any project by running:

```
dotnet run --project src/<PROJECT>/<PROJECT>.csproj --framework net7.0
```

Note that when generating the data, you must run the projects in the following order:

1. `Teams`
2. `Games`
3. `Stats`

To run the `Learn` project, run the following command:

```
dotnet run --project src/Learn/AwayScoreModel/AwayScoreModel.csproj -- <TEAM A ID> <TEAM B ID>
```

## Results

Will update after Selection Sunday.
