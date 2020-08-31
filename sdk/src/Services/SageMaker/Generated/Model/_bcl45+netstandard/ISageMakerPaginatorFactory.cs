#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Paginators for the SageMaker service
    ///</summary>
    public interface ISageMakerPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAlgorithms operation
        ///</summary>
        IListAlgorithmsPaginator ListAlgorithms(ListAlgorithmsRequest request);

        /// <summary>
        /// Paginator for ListApps operation
        ///</summary>
        IListAppsPaginator ListApps(ListAppsRequest request);

        /// <summary>
        /// Paginator for ListAutoMLJobs operation
        ///</summary>
        IListAutoMLJobsPaginator ListAutoMLJobs(ListAutoMLJobsRequest request);

        /// <summary>
        /// Paginator for ListCandidatesForAutoMLJob operation
        ///</summary>
        IListCandidatesForAutoMLJobPaginator ListCandidatesForAutoMLJob(ListCandidatesForAutoMLJobRequest request);

        /// <summary>
        /// Paginator for ListCodeRepositories operation
        ///</summary>
        IListCodeRepositoriesPaginator ListCodeRepositories(ListCodeRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListCompilationJobs operation
        ///</summary>
        IListCompilationJobsPaginator ListCompilationJobs(ListCompilationJobsRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListEndpointConfigs operation
        ///</summary>
        IListEndpointConfigsPaginator ListEndpointConfigs(ListEndpointConfigsRequest request);

        /// <summary>
        /// Paginator for ListEndpoints operation
        ///</summary>
        IListEndpointsPaginator ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Paginator for ListExperiments operation
        ///</summary>
        IListExperimentsPaginator ListExperiments(ListExperimentsRequest request);

        /// <summary>
        /// Paginator for ListFlowDefinitions operation
        ///</summary>
        IListFlowDefinitionsPaginator ListFlowDefinitions(ListFlowDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListHumanTaskUis operation
        ///</summary>
        IListHumanTaskUisPaginator ListHumanTaskUis(ListHumanTaskUisRequest request);

        /// <summary>
        /// Paginator for ListHyperParameterTuningJobs operation
        ///</summary>
        IListHyperParameterTuningJobsPaginator ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request);

        /// <summary>
        /// Paginator for ListLabelingJobs operation
        ///</summary>
        IListLabelingJobsPaginator ListLabelingJobs(ListLabelingJobsRequest request);

        /// <summary>
        /// Paginator for ListLabelingJobsForWorkteam operation
        ///</summary>
        IListLabelingJobsForWorkteamPaginator ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request);

        /// <summary>
        /// Paginator for ListModelPackages operation
        ///</summary>
        IListModelPackagesPaginator ListModelPackages(ListModelPackagesRequest request);

        /// <summary>
        /// Paginator for ListModels operation
        ///</summary>
        IListModelsPaginator ListModels(ListModelsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringExecutions operation
        ///</summary>
        IListMonitoringExecutionsPaginator ListMonitoringExecutions(ListMonitoringExecutionsRequest request);

        /// <summary>
        /// Paginator for ListMonitoringSchedules operation
        ///</summary>
        IListMonitoringSchedulesPaginator ListMonitoringSchedules(ListMonitoringSchedulesRequest request);

        /// <summary>
        /// Paginator for ListNotebookInstanceLifecycleConfigs operation
        ///</summary>
        IListNotebookInstanceLifecycleConfigsPaginator ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request);

        /// <summary>
        /// Paginator for ListNotebookInstances operation
        ///</summary>
        IListNotebookInstancesPaginator ListNotebookInstances(ListNotebookInstancesRequest request);

        /// <summary>
        /// Paginator for ListProcessingJobs operation
        ///</summary>
        IListProcessingJobsPaginator ListProcessingJobs(ListProcessingJobsRequest request);

        /// <summary>
        /// Paginator for ListSubscribedWorkteams operation
        ///</summary>
        IListSubscribedWorkteamsPaginator ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for ListTrainingJobs operation
        ///</summary>
        IListTrainingJobsPaginator ListTrainingJobs(ListTrainingJobsRequest request);

        /// <summary>
        /// Paginator for ListTrainingJobsForHyperParameterTuningJob operation
        ///</summary>
        IListTrainingJobsForHyperParameterTuningJobPaginator ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request);

        /// <summary>
        /// Paginator for ListTransformJobs operation
        ///</summary>
        IListTransformJobsPaginator ListTransformJobs(ListTransformJobsRequest request);

        /// <summary>
        /// Paginator for ListTrialComponents operation
        ///</summary>
        IListTrialComponentsPaginator ListTrialComponents(ListTrialComponentsRequest request);

        /// <summary>
        /// Paginator for ListTrials operation
        ///</summary>
        IListTrialsPaginator ListTrials(ListTrialsRequest request);

        /// <summary>
        /// Paginator for ListUserProfiles operation
        ///</summary>
        IListUserProfilesPaginator ListUserProfiles(ListUserProfilesRequest request);

        /// <summary>
        /// Paginator for ListWorkforces operation
        ///</summary>
        IListWorkforcesPaginator ListWorkforces(ListWorkforcesRequest request);

        /// <summary>
        /// Paginator for ListWorkteams operation
        ///</summary>
        IListWorkteamsPaginator ListWorkteams(ListWorkteamsRequest request);

        /// <summary>
        /// Paginator for Search operation
        ///</summary>
        ISearchPaginator Search(SearchRequest request);
    }
}
#endif