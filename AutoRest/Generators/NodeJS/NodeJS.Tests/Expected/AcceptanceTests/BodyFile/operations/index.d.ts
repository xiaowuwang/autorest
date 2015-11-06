/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
*/

import { ServiceClientOptions, RequestOptions, ServiceCallback } from 'ms-rest';
import * as stream from 'stream';
import * as models from '../models';


/**
 * @class
 * Files
 * __NOTE__: An instance of this class is automatically created for an
 * instance of the AutoRestSwaggerBATFileService.
 */
export interface Files {

    /**
     * Get file
     *
     * @param {object} [options]
     *
     * @param {object} [options.customHeaders] headers that will be added to
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getFile(options: RequestOptions, callback: ServiceCallback<stream.Readable>): void;
    getFile(callback: ServiceCallback<stream.Readable>): void;

    /**
     * Get empty file
     *
     * @param {object} [options]
     *
     * @param {object} [options.customHeaders] headers that will be added to
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getEmptyFile(options: RequestOptions, callback: ServiceCallback<stream.Readable>): void;
    getEmptyFile(callback: ServiceCallback<stream.Readable>): void;
}