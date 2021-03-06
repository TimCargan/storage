﻿using Storage.Net.Aws.Blob;
using Storage.Net.Blob;

namespace Storage.Net
{
   /// <summary>
   /// Factory class that implement factory methods for Amazon AWS implementation
   /// </summary>
   public static class Factory
   {

      /// <summary>
      /// Creates an Amazon S3 storage
      /// </summary>
      /// <param name="factory">Factory reference</param>
      /// <param name="accessKeyId">Access key ID</param>
      /// <param name="secretAccessKey">Secret access key</param>
      /// <param name="bucketName">Bucket name</param>
      /// <returns>A reference to the created storage</returns>
      public static IBlobStorageProvider AmazonS3BlobStorage(this IBlobStorageFactory factory,
         string accessKeyId,
         string secretAccessKey,
         string bucketName)
      {
         return new AwsS3BlobStorageProvider(accessKeyId, secretAccessKey, bucketName);
      }
   }
}
