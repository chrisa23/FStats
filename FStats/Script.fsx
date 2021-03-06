﻿#r @"..\FStats\bin\Debug\FStats.dll"

open System
open FStats

// Statistics

let rand = Random()

let data =
    [ for x in 0 .. 10000 do
        yield rand.NextDouble() * 10.
    ]

let stats = DescriptiveStatistics.describe data

let interQuartileRange   = stats.InterQuartileRange
let interQuartileRange'  = Statistics.interQuartileRange data
let interQuartileRange'' = Seq.interQuartileRange data

let q1 = stats.LowerQuartile
let q1' = Statistics.lowerQuartile data
let q1'' = Seq.lowerQuartile data

let maximum   = stats.Maximum
let maximum'  = Statistics.maximum data
let maximum'' = Seq.maximum data

let mean   = stats.Mean
let mean'  = Statistics.mean data
let mean'' = Seq.mean data

let median   = stats.Median
let median'  = Statistics.median data
let median'' = Seq.median data

let minimum   = stats.Minimum
let minimum'  = Statistics.minimum data
let minimum'' = Seq.minimum data

let mode   = stats.Mode
let mode'  = Statistics.mode data
let mode'' = Seq.mode data

let percentile25  = Statistics.percentile 25 data
let percentile25' = Seq.percentile 25 data

let percentile50  = Statistics.percentile 50 data
let percentile50' = Seq.percentile 50 data

let percentile75  = Statistics.percentile 75 data
let percentile75' = Seq.percentile 75 data

let popStdDev   = stats.PopulationStandardDeviation
let popStdDev'  = Statistics.populationStandardDeviation data
let popStdDev'' = Seq.populationStandardDeviation data

let popVariance   = stats.PopulationVariance
let popVariance'  = Statistics.populationVariance data
let popVariance'' = Seq.populationVariance data

let firstQuartile  = Statistics.quartile 1 data
let firstQuartile' = Seq.quartile 1 data

let secondQuartile  = Statistics.quartile 2 data
let secondQuartile' = Seq.quartile 2 data

let thirdQuartile  = Statistics.quartile 3 data
let thirdQuartile' = Seq.quartile 3 data

let range   = stats.Range
let range'  = Statistics.range data
let range'' = Seq.range data

let stdDev   = stats.StandardDeviation
let stdDev'  = Statistics.standardDeviation data
let stdDev'' = Seq.standardDeviation data

let q3   = stats.UpperQuartile
let q3'  = Statistics.upperQuartile data
let q3'' = Seq.upperQuartile data

let variance   = stats.Variance
let variance'  = Statistics.variance data
let variance'' = Seq.variance data

let standardScore  = Statistics.zScore 500. data
let standardScore' = Seq.zScore 500. data


// Correlation

let data' =
    [ for x in 0 .. 10000 do
        yield rand.NextDouble() * 10.
    ]

let covariance = Correlation.covariance data data'

let covariance' = Correlation.populationCovariance data data'

let correlationCoefficient = Correlation.coefficient data data'

let trend = Correlation.predict data data' 100.
