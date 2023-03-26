using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReportB2C.Models;

public partial class NewB2cContext : DbContext
{
    public NewB2cContext()
    {
    }

    public NewB2cContext(DbContextOptions<NewB2cContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressDssTracking> AddressDssTrackings { get; set; }

    public virtual DbSet<Agreement> Agreements { get; set; }

    public virtual DbSet<AssetEvent> AssetEvents { get; set; }

    public virtual DbSet<BagsType> BagsTypes { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<Brainhint> Brainhints { get; set; }

    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<CasesInBag> CasesInBags { get; set; }

    public virtual DbSet<CasesOfListOfCase> CasesOfListOfCases { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<ContactsDetail> ContactsDetails { get; set; }

    public virtual DbSet<ContatsOfClient> ContatsOfClients { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContratsFile> ContratsFiles { get; set; }

    public virtual DbSet<CustomBagsNote> CustomBagsNotes { get; set; }

    public virtual DbSet<CustomListOfCase> CustomListOfCases { get; set; }

    public virtual DbSet<Czynnosci> Czynnoscis { get; set; }

    public virtual DbSet<DictCaseState> DictCaseStates { get; set; }

    public virtual DbSet<DictCommisionType> DictCommisionTypes { get; set; }

    public virtual DbSet<DictDefaultNote> DictDefaultNotes { get; set; }

    public virtual DbSet<DictEventType> DictEventTypes { get; set; }

    public virtual DbSet<DictStateOfCommitment> DictStateOfCommitments { get; set; }

    public virtual DbSet<DoKrd> DoKrds { get; set; }

    public virtual DbSet<Dopoprawienium> Dopoprawienia { get; set; }

    public virtual DbSet<DynamicalCaseParametr> DynamicalCaseParametrs { get; set; }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<EmailsAddress> EmailsAddresses { get; set; }

    public virtual DbSet<Encryption> Encryptions { get; set; }

    public virtual DbSet<EncryptionApplication> EncryptionApplications { get; set; }

    public virtual DbSet<EnforcementBailiff> EnforcementBailiffs { get; set; }

    public virtual DbSet<EpuCase> EpuCases { get; set; }

    public virtual DbSet<EpuDecision> EpuDecisions { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventsForInvoice> EventsForInvoices { get; set; }

    public virtual DbSet<EventsOfAgrement> EventsOfAgrements { get; set; }

    public virtual DbSet<Eventsbac> Eventsbacs { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<FileType> FileTypes { get; set; }

    public virtual DbSet<FilesOfCase> FilesOfCases { get; set; }

    public virtual DbSet<FilesOfClient> FilesOfClients { get; set; }

    public virtual DbSet<FilesOfEent> FilesOfEents { get; set; }

    public virtual DbSet<FilesOfEmail> FilesOfEmails { get; set; }

    public virtual DbSet<Fine> Fines { get; set; }

    public virtual DbSet<Fine1> Fines1 { get; set; }

    public virtual DbSet<Gapowicze> Gapowiczes { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }

    public virtual DbSet<Krd> Krds { get; set; }

    public virtual DbSet<KrdOld> KrdOlds { get; set; }

    public virtual DbSet<Lista3> Lista3s { get; set; }

    public virtual DbSet<Lista4> Lista4s { get; set; }

    public virtual DbSet<Lista5> Lista5s { get; set; }

    public virtual DbSet<Lista6> Lista6s { get; set; }

    public virtual DbSet<Lista7> Lista7s { get; set; }

    public virtual DbSet<Listape> Listapes { get; set; }

    public virtual DbSet<MappingZipCodeToDistrict> MappingZipCodeToDistricts { get; set; }

    public virtual DbSet<MappingZipCodeToDistrictOld> MappingZipCodeToDistrictOlds { get; set; }

    public virtual DbSet<Mytesttable> Mytesttables { get; set; }

    public virtual DbSet<Mytesttable1> Mytesttable1s { get; set; }

    public virtual DbSet<NowePrzydzialkolor> NowePrzydzialkolors { get; set; }

    public virtual DbSet<NowePrzydzialy> NowePrzydzialies { get; set; }

    public virtual DbSet<NowePrzydzialyOd18062015> NowePrzydzialyOd18062015s { get; set; }

    public virtual DbSet<Odsetki> Odsetkis { get; set; }

    public virtual DbSet<P> Ps { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentsForFine> PaymentsForFines { get; set; }

    public virtual DbSet<Pe> Pes { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<Pes2> Pes2s { get; set; }

    public virtual DbSet<Pesel> Pesels { get; set; }

    public virtual DbSet<PeseleN> PeseleNs { get; set; }

    public virtual DbSet<Pezypisane30112018> Pezypisane30112018s { get; set; }

    public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

    public virtual DbSet<Pko> Pkoes { get; set; }

    public virtual DbSet<PkpintercitySyg> PkpintercitySygs { get; set; }

    public virtual DbSet<Podzial2> Podzial2s { get; set; }

    public virtual DbSet<Postanowienium> Postanowienia { get; set; }

    public virtual DbSet<PowerbiOdzyskiNowePortfele> PowerbiOdzyskiNowePortfeles { get; set; }

    public virtual DbSet<PowerbiOdzyskiStarePortfele> PowerbiOdzyskiStarePortfeles { get; set; }

    public virtual DbSet<PowerbiV1WplatyNaZlecenie> PowerbiV1WplatyNaZlecenies { get; set; }

    public virtual DbSet<Projectpoland> Projectpolands { get; set; }

    public virtual DbSet<ProvisionMarkerDss> ProvisionMarkerDsses { get; set; }

    public virtual DbSet<Przewozy> Przewozies { get; set; }

    public virtual DbSet<Przyd30062015> Przyd30062015s { get; set; }

    public virtual DbSet<Przyd300620151422> Przyd300620151422s { get; set; }

    public virtual DbSet<Przydzialy> Przydzialies { get; set; }

    public virtual DbSet<Pub11> Pub11s { get; set; }

    public virtual DbSet<Pub2> Pub2s { get; set; }

    public virtual DbSet<Pub22> Pub22s { get; set; }

    public virtual DbSet<Pw2> Pw2s { get; set; }

    public virtual DbSet<Pw3> Pw3s { get; set; }

    public virtual DbSet<Reprezentacja> Reprezentacjas { get; set; }

    public virtual DbSet<RequestsCase> RequestsCases { get; set; }

    public virtual DbSet<RequestsPayment> RequestsPayments { get; set; }

    public virtual DbSet<SchemaInfoDss> SchemaInfoDsses { get; set; }

    public virtual DbSet<ScopeConfigDss> ScopeConfigDsses { get; set; }

    public virtual DbSet<ScopeInfoDss> ScopeInfoDsses { get; set; }

    public virtual DbSet<Signature> Signatures { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<Smstemplate> Smstemplates { get; set; }

    public virtual DbSet<SortVisibleCase> SortVisibleCases { get; set; }

    public virtual DbSet<StareMiasto> StareMiastos { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StopyLombardowe> StopyLombardowes { get; set; }

    public virtual DbSet<SystemLog> SystemLogs { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<TempPlaned> TempPlaneds { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TmpMojeSprawy> TmpMojeSprawies { get; set; }

    public virtual DbSet<Umowb> Umowbs { get; set; }

    public virtual DbSet<Umowb2> Umowb2s { get; set; }

    public virtual DbSet<Umowb2c1> Umowb2c1s { get; set; }

    public virtual DbSet<Umowb3> Umowb3s { get; set; }

    public virtual DbSet<Umowyb2c> Umowyb2cs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserConfiguration> UserConfigurations { get; set; }

    public virtual DbSet<Warrant> Warrants { get; set; }

    public virtual DbSet<Wplaty> Wplaties { get; set; }

    public virtual DbSet<WplatyCesje> WplatyCesjes { get; set; }

    public virtual DbSet<WplatyCesjePerWindykator> WplatyCesjePerWindykators { get; set; }

    public virtual DbSet<WplatyZleceniaPerWindykator> WplatyZleceniaPerWindykators { get; set; }

    public virtual DbSet<Wysi> Wysis { get; set; }

    public virtual DbSet<Yonick1> Yonick1s { get; set; }

    public virtual DbSet<Zap2> Zap2s { get; set; }

    public virtual DbSet<Zeszyt1> Zeszyt1s { get; set; }

    public virtual DbSet<_16092019zmianaProwadzacego> _16092019zmianaProwadzacegos { get; set; }

    public virtual DbSet<_18092019zmianaProwadzacych> _18092019zmianaProwadzacyches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.1.210\\TEST;Database=newB2C;Encrypt=False;Initial Catalog=newB2C;User ID=newB2C;Password=Statima1@");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address", tb =>
                {
                    tb.HasTrigger("Address_dss_delete_trigger");
                    tb.HasTrigger("Address_dss_insert_trigger");
                    tb.HasTrigger("Address_dss_update_trigger");
                });

            entity.HasIndex(e => e.Number, "AS_NonClusteredIndex-20190416-113235").HasFillFactor(90);

            entity.HasIndex(e => e.CityId, "AS_NonClusteredIndex-20190416-113256").HasFillFactor(90);

            entity.HasIndex(e => new { e.Number, e.CityId, e.Street }, "STA_Idx_Address_number_cityID_street_personId").HasFillFactor(90);

            entity.HasIndex(e => e.PersonId, "idx_Person_notnull")
                .IsUnique()
                .HasFilter("([personId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CityId).HasColumnName("cityID");
            entity.Property(e => e.Local)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("local");
            entity.Property(e => e.Number)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Street)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");

            entity.HasOne(d => d.City).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Address_Cities");

            entity.HasOne(d => d.Person).WithOne(p => p.Address)
                .HasForeignKey<Address>(d => d.PersonId)
                .HasConstraintName("FK_Address_Persons");
        });

        modelBuilder.Entity<AddressDssTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DataSync.Address_dss_tracking");

            entity.ToTable("Address_dss_tracking", "DataSync");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");
            entity.Property(e => e.LastChangeDatetime)
                .HasColumnType("datetime")
                .HasColumnName("last_change_datetime");
            entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");
            entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");
            entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");
            entity.Property(e => e.LocalUpdatePeerTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("local_update_peer_timestamp");
            entity.Property(e => e.RestoreTimestamp).HasColumnName("restore_timestamp");
            entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");
            entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");
            entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");
            entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");
            entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");
            entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
        });

        modelBuilder.Entity<Agreement>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");

            entity.HasOne(d => d.Case).WithMany(p => p.Agreements)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_Agreements_Case");
        });

        modelBuilder.Entity<AssetEvent>(entity =>
        {
            entity.HasIndex(e => e.EventsId, "AS_NonClusteredIndex-20190417-151410").HasFillFactor(90);

            entity.HasIndex(e => new { e.User2Id, e.User1Id }, "missing_index_25_24").HasFillFactor(90);

            entity.HasIndex(e => new { e.User1Id, e.User2Id }, "missing_index_4_3").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssetDate)
                .HasColumnType("datetime")
                .HasColumnName("assetDate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Desription)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("desription");
            entity.Property(e => e.EventsId).HasColumnName("eventsId");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.User1Id).HasColumnName("user1Id");
            entity.Property(e => e.User2Id).HasColumnName("user2Id");

            entity.HasOne(d => d.Events).WithMany(p => p.AssetEvents)
                .HasForeignKey(d => d.EventsId)
                .HasConstraintName("FK_AssetEvents_Events");

            entity.HasOne(d => d.User1).WithMany(p => p.AssetEventUser1s)
                .HasForeignKey(d => d.User1Id)
                .HasConstraintName("FK_AssetEvents_Users");

            entity.HasOne(d => d.User2).WithMany(p => p.AssetEventUser2s)
                .HasForeignKey(d => d.User2Id)
                .HasConstraintName("FK_AssetEvents_Users1");
        });

        modelBuilder.Entity<BagsType>(entity =>
        {
            entity.ToTable("BagsType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IconName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("iconName");
            entity.Property(e => e.IsSystem).HasColumnName("isSystem");
            entity.Property(e => e.IsVisible).HasColumnName("isVisible");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.Iban)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IBAN");
            entity.Property(e => e.Nr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nr");
            entity.Property(e => e.Swift)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SWIFT");

            entity.HasOne(d => d.Client).WithMany(p => p.BankAccounts)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_BankAccounts_BankAccounts");
        });

        modelBuilder.Entity<Brainhint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("brainhint");

            entity.Property(e => e.Expr1)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Kwota).HasColumnName("kwota");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("PESEL");
            entity.Property(e => e.Sha1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHA1");
            entity.Property(e => e.Signatures)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("signatures");
            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Case>(entity =>
        {
            entity.ToTable("Case");

            entity.HasIndex(e => e.Signatures, "IX_CaseSignature").HasFillFactor(90);

            entity.HasIndex(e => e.PersonId, "NonClusteredIndex-20190416-062109").HasFillFactor(90);

            entity.HasIndex(e => e.LeadingUserId, "NonClusteredIndex-20190416-062228").HasFillFactor(90);

            entity.HasIndex(e => e.StateId, "STA_Idx_Case").HasFillFactor(90);

            entity.HasIndex(e => e.UserId, "missing_index_537_536").HasFillFactor(90);

            entity.HasIndex(e => e.ContractFilesId, "missing_index_546_545").HasFillFactor(90);

            entity.HasIndex(e => e.ContractFilesId, "missing_index_9959_9958").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.BankAccountId).HasColumnName("bankAccountId");
            entity.Property(e => e.BaseAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("baseAmount");
            entity.Property(e => e.CommitmentStateId).HasColumnName("CommitmentStateID");
            entity.Property(e => e.ContractFilesId).HasColumnName("contractFilesId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.LeadingUserId).HasColumnName("leadingUserId");
            entity.Property(e => e.MandateNumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mandateNumber");
            entity.Property(e => e.Payments)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("payments");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Signatures)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("signatures");
            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.TimeToDo)
                .HasColumnType("datetime")
                .HasColumnName("timeToDo");
            entity.Property(e => e.ToDoEventsId).HasColumnName("toDoEventsId");
            entity.Property(e => e.UserId).HasColumnName("userID");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.Cases)
                .HasForeignKey(d => d.BankAccountId)
                .HasConstraintName("FK_Case_BankAccounts");

            entity.HasOne(d => d.CommitmentState).WithMany(p => p.Cases)
                .HasForeignKey(d => d.CommitmentStateId)
                .HasConstraintName("FK_Case_DictStateOfCommitment");

            entity.HasOne(d => d.ContractFiles).WithMany(p => p.Cases)
                .HasForeignKey(d => d.ContractFilesId)
                .HasConstraintName("FK_Case_ContratsFiles");

            entity.HasOne(d => d.LeadingUser).WithMany(p => p.CaseLeadingUsers)
                .HasForeignKey(d => d.LeadingUserId)
                .HasConstraintName("FK_Case_Users");

            entity.HasOne(d => d.Person).WithMany(p => p.Cases)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_Case_Persons");

            entity.HasOne(d => d.State).WithMany(p => p.Cases)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Case_DictCaseState");

            entity.HasOne(d => d.ToDoEvents).WithMany(p => p.Cases)
                .HasForeignKey(d => d.ToDoEventsId)
                .HasConstraintName("FK_Case_Events");

            entity.HasOne(d => d.User).WithMany(p => p.CaseUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Case_Case");
        });

        modelBuilder.Entity<CasesInBag>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BagsTypeId).HasColumnName("bagsTypeId");
            entity.Property(e => e.CaseId).HasColumnName("caseID");

            entity.HasOne(d => d.BagsType).WithMany(p => p.CasesInBags)
                .HasForeignKey(d => d.BagsTypeId)
                .HasConstraintName("FK_CasesInBags_BagsType");

            entity.HasOne(d => d.Case).WithMany(p => p.CasesInBags)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_CasesInBags_Case");
        });

        modelBuilder.Entity<CasesOfListOfCase>(entity =>
        {
            entity.HasIndex(e => e.ListOfCasesId, "missing_index_112_111");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.ListOfCasesId).HasColumnName("listOfCases_id");

            entity.HasOne(d => d.Case).WithMany(p => p.CasesOfListOfCases)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_CasesOfListOfCases_Case");

            entity.HasOne(d => d.ListOfCases).WithMany(p => p.CasesOfListOfCases)
                .HasForeignKey(d => d.ListOfCasesId)
                .HasConstraintName("FK_CasesOfListOfCases_CustomListOfCases");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_Cities").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasIndex(e => e.AddressId, "idx_Clients_notnull").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("addressId");
            entity.Property(e => e.BankAccountNr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankAccountNr");
            entity.Property(e => e.ClientType).HasColumnName("clientType");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactNumber");
            entity.Property(e => e.FullName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("fullName");
            entity.Property(e => e.Krs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KRS");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NazwaKontaDoWplaty)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("nazwaKontaDoWplaty");
            entity.Property(e => e.NextTimeToDo)
                .HasColumnType("datetime")
                .HasColumnName("nextTimeToDo");
            entity.Property(e => e.Nip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIP");
            entity.Property(e => e.Note)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.Regon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("regon");
            entity.Property(e => e.RejestrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rejestrName");
            entity.Property(e => e.RejestrProwadzacy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("rejestrProwadzacy");
            entity.Property(e => e.RejestrType).HasColumnName("rejestrType");
            entity.Property(e => e.RekCount).HasColumnName("rekCount");
            entity.Property(e => e.ReturnBankAccountNr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("returnBankAccountNr");
            entity.Property(e => e.ReturnBankOwner)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("returnBankOwner");
            entity.Property(e => e.Siedziba)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("siedziba");
            entity.Property(e => e.ToDoEventsId).HasColumnName("toDoEventsId");
            entity.Property(e => e.ZipName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("zipName");

            entity.HasOne(d => d.Address).WithMany(p => p.Clients)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Clients_Address");

            entity.HasOne(d => d.ToDoEvents).WithMany(p => p.Clients)
                .HasForeignKey(d => d.ToDoEventsId)
                .HasConstraintName("FK_Clients_Events");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nip)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("NIP");
        });

        modelBuilder.Entity<ContactsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Contacts");

            entity.ToTable("ContactsDetail");

            entity.HasIndex(e => e.LastName, "IX_ContactsDetail").HasFillFactor(90);

            entity.HasIndex(e => e.Pesel, "IX_ContactsDetail_2").HasFillFactor(90);

            entity.HasIndex(e => e.FirstName, "IX_ContactsDetail_3").HasFillFactor(90);

            entity.HasIndex(e => e.Pesel, "STA_Idx_PESEL").HasFillFactor(90);

            entity.HasIndex(e => e.PersonId, "idx_ContactsDetail_notnull")
                .IsUnique()
                .HasFilter("([personId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Nip)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NIP");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("note");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("PESEL");
            entity.Property(e => e.SecoundName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("secoundName");

            entity.HasOne(d => d.Person).WithOne(p => p.ContactsDetail)
                .HasForeignKey<ContactsDetail>(d => d.PersonId)
                .HasConstraintName("FK_Contacts_Persons");
        });

        modelBuilder.Entity<ContatsOfClient>(entity =>
        {
            entity.ToTable("ContatsOfClient");

            entity.HasIndex(e => e.PersonId, "idx_ContatsOfClient_notnull")
                .IsUnique()
                .HasFilter("([personId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");

            entity.HasOne(d => d.Client).WithMany(p => p.ContatsOfClients)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContatsOfClient_Clients");

            entity.HasOne(d => d.Person).WithOne(p => p.ContatsOfClient)
                .HasForeignKey<ContatsOfClient>(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContatsOfClient_Persons");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aprefix)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("aprefix");
            entity.Property(e => e.BankAcount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankAcount");
            entity.Property(e => e.CarierName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("carierName");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.InterstShift).HasColumnName("interstShift");
            entity.Property(e => e.Koszt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("koszt");
            entity.Property(e => e.KwotaZakupu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kwotaZakupu");
            entity.Property(e => e.MaxPayments)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("maxPayments");
            entity.Property(e => e.NaleznoscGlowna)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("naleznoscGlowna");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NazwaKodowa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nazwaKodowa");
            entity.Property(e => e.NazwaKontaDoWplaty)
                .HasMaxLength(1500)
                .IsUnicode(false)
                .HasColumnName("nazwaKontaDoWplaty");
            entity.Property(e => e.Percentage)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("percentage");
            entity.Property(e => e.Percentage3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("percentage3");
            entity.Property(e => e.PostAuthor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("postAuthor");
            entity.Property(e => e.RaportTemplateId).HasColumnName("raportTemplateId");
            entity.Property(e => e.TerminationDate)
                .HasColumnType("date")
                .HasColumnName("terminationDate");
            entity.Property(e => e.TerminationDay).HasColumnName("terminationDay");
            entity.Property(e => e.TerminationPercange)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("terminationPercange");
            entity.Property(e => e.ThumabailId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("thumabailId");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WindykacjOdsetki)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("windykacjOdsetki");

            entity.HasOne(d => d.Client).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Contracts_Clients");

            entity.HasOne(d => d.Company).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Contracts_Company");
        });

        modelBuilder.Entity<ContratsFile>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommisionType).HasColumnName("commisionType");
            entity.Property(e => e.CommisionValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("commisionValue");
            entity.Property(e => e.ContractId).HasColumnName("contractId");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateReturned)
                .HasColumnType("date")
                .HasColumnName("dateReturned");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContratsFiles)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("FK_ContratsFiles_Contracts");
        });

        modelBuilder.Entity<CustomBagsNote>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BagsId).HasColumnName("bagsId");
            entity.Property(e => e.DefaultNotesId).HasColumnName("defaultNotesId");

            entity.HasOne(d => d.Bags).WithMany(p => p.CustomBagsNotes)
                .HasForeignKey(d => d.BagsId)
                .HasConstraintName("FK_CustomBagsNotes_BagsType");

            entity.HasOne(d => d.DefaultNotes).WithMany(p => p.CustomBagsNotes)
                .HasForeignKey(d => d.DefaultNotesId)
                .HasConstraintName("FK_CustomBagsNotes_DictDefaultNotes");
        });

        modelBuilder.Entity<CustomListOfCase>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Czynnosci>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Czynnosci");

            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 2");
            entity.Property(e => e.Osoba)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("osoba");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
        });

        modelBuilder.Entity<DictCaseState>(entity =>
        {
            entity.ToTable("DictCaseState");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DictCommisionType>(entity =>
        {
            entity.ToTable("DictCommisionType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DictDefaultNote>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DictEventType>(entity =>
        {
            entity.ToTable("DictEventType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IconName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("iconName");
            entity.Property(e => e.IsSystemEvent).HasColumnName("isSystemEvent");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DictStateOfCommitment>(entity =>
        {
            entity.ToTable("DictStateOfCommitment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DoKrd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Do KRD");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dopoprawienium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Kwotabazowa)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Neelementu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DynamicalCaseParametr>(entity =>
        {
            entity.ToTable("DynamicalCaseParametr");

            entity.HasIndex(e => e.FineId, "AS_NonClusteredIndex-20190416-110330").HasFillFactor(90);

            entity.HasIndex(e => e.Name, "STA_Idx_DynamicalCaseParametr_value_fineId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.FineId).HasColumnName("fineId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("value");

            entity.HasOne(d => d.Case).WithMany(p => p.DynamicalCaseParametrs)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_DynamicalCaseParametr_Case");

            entity.HasOne(d => d.Fine).WithMany(p => p.DynamicalCaseParametrs)
                .HasForeignKey(d => d.FineId)
                .HasConstraintName("FK_DynamicalCaseParametr_Fine");
        });

        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Emails_1");

            entity.HasIndex(e => e.UserId, "missing_index_12_11");

            entity.HasIndex(e => new { e.Status, e.SendDate }, "missing_index_2_1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmailContent).HasColumnName("emailContent");
            entity.Property(e => e.EmailFrom)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("emailFrom");
            entity.Property(e => e.EmailId).HasColumnName("emailId");
            entity.Property(e => e.EmailTo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("emailTo");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.IsReaded).HasColumnName("isReaded");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.ReciveDate)
                .HasColumnType("datetime")
                .HasColumnName("reciveDate");
            entity.Property(e => e.SendDate)
                .HasColumnType("datetime")
                .HasColumnName("sendDate");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Uid).HasColumnName("uid");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Event).WithMany(p => p.Emails)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_Emails_Events");

            entity.HasOne(d => d.Person).WithMany(p => p.Emails)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_Emails_Persons1");

            entity.HasOne(d => d.User).WithMany(p => p.Emails)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Emails_Users");
        });

        modelBuilder.Entity<EmailsAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Emails");

            entity.HasIndex(e => e.PersonId, "AS_NonClusteredIndex-20190417-140535").HasFillFactor(90);

            entity.HasIndex(e => e.Email, "IX_EmailsAddresses").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PersonId).HasColumnName("personId");

            entity.HasOne(d => d.Person).WithMany(p => p.EmailsAddresses)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_Emails_Persons");
        });

        modelBuilder.Entity<Encryption>(entity =>
        {
            entity.ToTable("encryption");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.EncrytipnApId).HasColumnName("encrytipnApId");
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("password");

            entity.HasOne(d => d.Client).WithMany(p => p.Encryptions)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_encryption_Clients");

            entity.HasOne(d => d.EncrytipnAp).WithMany(p => p.Encryptions)
                .HasForeignKey(d => d.EncrytipnApId)
                .HasConstraintName("FK_encryption_EncryptionApplication");
        });

        modelBuilder.Entity<EncryptionApplication>(entity =>
        {
            entity.ToTable("EncryptionApplication");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ParametersDec)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("parametersDec");
            entity.Property(e => e.ParametersEnc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("parametersEnc");
            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("path");
        });

        modelBuilder.Entity<EnforcementBailiff>(entity =>
        {
            entity.ToTable("EnforcementBailiff");

            entity.HasIndex(e => e.CaseId, "idx_EnforcementBailiff_notnull")
                .IsUnique()
                .HasFilter("([caseId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.EnforcmentSignature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("enforcmentSignature");
            entity.Property(e => e.Kze)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kze");

            entity.HasOne(d => d.Case).WithOne(p => p.EnforcementBailiff)
                .HasForeignKey<EnforcementBailiff>(d => d.CaseId)
                .HasConstraintName("FK_EnforcementBailiff_Case");
        });

        modelBuilder.Entity<EpuCase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EpuCase_1");

            entity.ToTable("EpuCase");

            entity.HasIndex(e => e.EsadId, "idx_EpuCase2_notnull")
                .IsUnique()
                .HasFilter("([esadId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.HasIndex(e => e.CaseId, "idx_EpuCase_notnull")
                .IsUnique()
                .HasFilter("([caseId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.EpuState).HasColumnName("epuState");
            entity.Property(e => e.EsadId).HasColumnName("esadId");

            entity.HasOne(d => d.Case).WithOne(p => p.EpuCase)
                .HasForeignKey<EpuCase>(d => d.CaseId)
                .HasConstraintName("FK_EpuCase_Case1");
        });

        modelBuilder.Entity<EpuDecision>(entity =>
        {
            entity.HasIndex(e => e.EvantId, "idx_EpuDecisions_notnull")
                .IsUnique()
                .HasFilter("([evantId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateReturned)
                .HasColumnType("date")
                .HasColumnName("dateReturned");
            entity.Property(e => e.EpuCaseId).HasColumnName("epuCaseId");
            entity.Property(e => e.EvantId).HasColumnName("evantId");
            entity.Property(e => e.Text)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("text");

            entity.HasOne(d => d.EpuCase).WithMany(p => p.EpuDecisions)
                .HasForeignKey(d => d.EpuCaseId)
                .HasConstraintName("FK_EpuDecisions_EpuCase");

            entity.HasOne(d => d.Evant).WithOne(p => p.EpuDecision)
                .HasForeignKey<EpuDecision>(d => d.EvantId)
                .HasConstraintName("FK_EpuDecisions_Events");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasIndex(e => e.PersonId, "AS_NonClusteredIndex-20190416-110510").HasFillFactor(90);

            entity.HasIndex(e => e.ClientId, "AS_NonClusteredIndex-20190417-101708").HasFillFactor(90);

            entity.HasIndex(e => e.UserId, "NonClusteredIndex-20190416-062628").HasFillFactor(90);

            entity.HasIndex(e => e.CaseId, "NonClusteredIndex-20190416-062650").HasFillFactor(90);

            entity.HasIndex(e => new { e.Direction, e.Planed, e.UserId, e.TypeId, e.Time }, "missing_index_541_540");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direction).HasColumnName("direction");
            entity.Property(e => e.Header)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("header");
            entity.Property(e => e.LastAsset).HasColumnName("lastAsset");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Planed).HasColumnName("planed");
            entity.Property(e => e.Text)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.TypeId).HasColumnName("typeId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Case).WithMany(p => p.Events)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_Events_Case");

            entity.HasOne(d => d.Client).WithMany(p => p.Events)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Events_Clients");

            entity.HasOne(d => d.LastAssetNavigation).WithMany(p => p.EventsNavigation)
                .HasForeignKey(d => d.LastAsset)
                .HasConstraintName("FK_Events_AssetEvents");
        });

        modelBuilder.Entity<EventsForInvoice>(entity =>
        {
            entity.ToTable("EventsForInvoice");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.InvoiceId).HasColumnName("invoiceId");

            entity.HasOne(d => d.Event).WithMany(p => p.EventsForInvoices)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_EventsForInvoice_Events");

            entity.HasOne(d => d.Invoice).WithMany(p => p.EventsForInvoices)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_EventsForInvoice_Invoices");
        });

        modelBuilder.Entity<EventsOfAgrement>(entity =>
        {
            entity.ToTable("EventsOfAgrement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgrrementId).HasColumnName("agrrementId");
            entity.Property(e => e.EventId).HasColumnName("eventId");

            entity.HasOne(d => d.Agrrement).WithMany(p => p.EventsOfAgrements)
                .HasForeignKey(d => d.AgrrementId)
                .HasConstraintName("FK_EventsOfAgrement_Agreements");

            entity.HasOne(d => d.Event).WithMany(p => p.EventsOfAgrements)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_EventsOfAgrement_Events");
        });

        modelBuilder.Entity<Eventsbac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Eventsbac");

            entity.Property(e => e.Direction).HasColumnName("direction");
            entity.Property(e => e.Header)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("header");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastAsset).HasColumnName("lastAsset");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Planed).HasColumnName("planed");
            entity.Property(e => e.Text)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("time");
            entity.Property(e => e.TypeId).HasColumnName("typeId");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FileTypeId).HasColumnName("fileTypeId");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("path");

            entity.HasOne(d => d.FileType).WithMany(p => p.Files)
                .HasForeignKey(d => d.FileTypeId)
                .HasConstraintName("FK_Files_FileTypes");
        });

        modelBuilder.Entity<FileType>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IconName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("iconName");
            entity.Property(e => e.IsEncrypted).HasColumnName("isEncrypted");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<FilesOfCase>(entity =>
        {
            entity.ToTable("FilesOfCase");

            entity.HasIndex(e => e.CaseId, "AS_NonClusteredIndex-20190416-110937").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.FileId).HasColumnName("fileId");

            entity.HasOne(d => d.Case).WithMany(p => p.FilesOfCases)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_FilesOfCase_Case");

            entity.HasOne(d => d.File).WithMany(p => p.FilesOfCases)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("FK_FilesOfCase_Files");
        });

        modelBuilder.Entity<FilesOfClient>(entity =>
        {
            entity.ToTable("FilesOfClient");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.FilesId).HasColumnName("filesId");

            entity.HasOne(d => d.Client).WithMany(p => p.FilesOfClients)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_FilesOfClient_Clients");

            entity.HasOne(d => d.Files).WithMany(p => p.FilesOfClients)
                .HasForeignKey(d => d.FilesId)
                .HasConstraintName("FK_FilesOfClient_Files");
        });

        modelBuilder.Entity<FilesOfEent>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.FileId).HasColumnName("fileId");

            entity.HasOne(d => d.Event).WithMany(p => p.FilesOfEents)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK_FilesOfEents_Events");

            entity.HasOne(d => d.File).WithMany(p => p.FilesOfEents)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("FK_FilesOfEents_Files");
        });

        modelBuilder.Entity<FilesOfEmail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmailId).HasColumnName("emailId");
            entity.Property(e => e.FilesId).HasColumnName("filesId");

            entity.HasOne(d => d.Email).WithMany(p => p.FilesOfEmails)
                .HasForeignKey(d => d.EmailId)
                .HasConstraintName("FK_FilesOfEmails_Emails");

            entity.HasOne(d => d.Files).WithMany(p => p.FilesOfEmails)
                .HasForeignKey(d => d.FilesId)
                .HasConstraintName("FK_FilesOfEmails_Files");
        });

        modelBuilder.Entity<Fine>(entity =>
        {
            entity.ToTable("Fine");

            entity.HasIndex(e => e.Nr, "AS_NonClusteredIndex-20190416-110030").HasFillFactor(90);

            entity.HasIndex(e => e.CaseId, "NonClusteredIndex-20190416-061859").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.InKrd).HasColumnName("inKRD");
            entity.Property(e => e.Interst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("interst");
            entity.Property(e => e.Koszty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("koszty");
            entity.Property(e => e.LesAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("lesAmount");
            entity.Property(e => e.LesInterst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("lesInterst");
            entity.Property(e => e.LesKoszty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("lesKoszty");
            entity.Property(e => e.Nr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nr");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.Case).WithMany(p => p.Fines)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_Fine_Case");
        });

        modelBuilder.Entity<Fine1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fines");

            entity.Property(e => e.CaseAmmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("case_ammount");
            entity.Property(e => e.CaseSignature)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("case_signature");
            entity.Property(e => e.MandatAmmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("mandat_ammount");
            entity.Property(e => e.MandatId).HasColumnName("mandat_id");
            entity.Property(e => e.MandatKoszty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("mandat_koszty");
            entity.Property(e => e.MandatOdsetki)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("mandat_odsetki");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PaymAmmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("paym_ammount");
            entity.Property(e => e.PaymKoszty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("paym_koszty");
            entity.Property(e => e.PaymOdsetki)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("paym_odsetki");
            entity.Property(e => e.Sha1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHA1");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Gapowicze>(entity =>
        {
            entity.ToTable("gapowicze");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("dateAdd");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.Case).WithMany(p => p.Gapowiczes)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_gapowicze_Case");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContratId).HasColumnName("contratID");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateOfPayment)
                .HasColumnType("date")
                .HasColumnName("dateOfPayment");
            entity.Property(e => e.EventId).HasColumnName("eventID");
            entity.Property(e => e.Nr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nr");

            entity.HasOne(d => d.Contrat).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.ContratId)
                .HasConstraintName("FK_Invoices_Contracts");
        });

        modelBuilder.Entity<InvoiceItem>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.FullAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("fullAmount");
            entity.Property(e => e.InoiceId).HasColumnName("inoiceId");
            entity.Property(e => e.Nr).HasColumnName("nr");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax");
            entity.Property(e => e.TaxRate).HasColumnName("taxRate");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.Inoice).WithMany(p => p.InvoiceItems)
                .HasForeignKey(d => d.InoiceId)
                .HasConstraintName("FK_InvoiceItems_Invoices");
        });

        modelBuilder.Entity<Krd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_KRDNew");

            entity.ToTable("KRD");

            entity.HasIndex(e => new { e.CaseId, e.State }, "missing_index_2_1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseID");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("dateAdd");
            entity.Property(e => e.DateDel)
                .HasColumnType("datetime")
                .HasColumnName("dateDel");
            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IsFromOldKrd).HasColumnName("isFromOldKRD");
            entity.Property(e => e.KrdGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("krdGuid");
            entity.Property(e => e.KrdId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("krdId");
            entity.Property(e => e.Krdlogin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("krdlogin");
            entity.Property(e => e.SendDocumentDate)
                .HasColumnType("datetime")
                .HasColumnName("sendDocumentDate");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.Case).WithMany(p => p.Krds)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_KRDNew_Case");
        });

        modelBuilder.Entity<KrdOld>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_KRD");

            entity.ToTable("KRD_OLD");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("dateAdd");
            entity.Property(e => e.DateDel)
                .HasColumnType("datetime")
                .HasColumnName("dateDel");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.KrdGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("krdGuid");
            entity.Property(e => e.KrdId).HasColumnName("krdID");
            entity.Property(e => e.SendDocumentDate)
                .HasColumnType("datetime")
                .HasColumnName("sendDocumentDate");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasOne(d => d.Case).WithMany(p => p.KrdOlds)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_KRD_Case");
        });

        modelBuilder.Entity<Lista3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista3");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lista4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista4");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pesel");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
        });

        modelBuilder.Entity<Lista5>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista5");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lista6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista6");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pesel");
            entity.Property(e => e.Signatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("signatura");
        });

        modelBuilder.Entity<Lista7>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("lista7");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Signature)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Listape>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("listapes");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pesel");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
        });

        modelBuilder.Entity<MappingZipCodeToDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MappingZipCodeToDistrict");

            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.ZipCode).HasMaxLength(255);
        });

        modelBuilder.Entity<MappingZipCodeToDistrictOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MappingZipCodeToDistrict_old");

            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.ZipCode).HasMaxLength(255);
        });

        modelBuilder.Entity<Mytesttable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mytesttable");

            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Rollno).HasColumnName("rollno");
        });

        modelBuilder.Entity<Mytesttable1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mytesttable1");

            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Rollno).HasColumnName("rollno");
        });

        modelBuilder.Entity<NowePrzydzialkolor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nowePrzydzialkolor");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data");
            entity.Property(e => e.Kolor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kolor");
            entity.Property(e => e.Przydzial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("przydzial");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
        });

        modelBuilder.Entity<NowePrzydzialy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nowePrzydzialy");

            entity.Property(e => e.Column0)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NowePrzydzialyOd18062015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nowePrzydzialyOd18062015");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data");
            entity.Property(e => e.DataKlauzula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dataKlauzula");
            entity.Property(e => e.DataOzreczenia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dataOzreczenia");
            entity.Property(e => e.DataPopelnieniaCzynu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dataPopelnieniaCzynu");
            entity.Property(e => e.DataPrawomoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dataPrawomoc");
            entity.Property(e => e.DniBezOdsetkowe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dniBezOdsetkowe");
            entity.Property(e => e.IdNakazu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idNakazu");
            entity.Property(e => e.IdPliku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_pliku");
            entity.Property(e => e.IdSprawy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_sprawy");
            entity.Property(e => e.ImieNazwisko)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Imie_Nazwisko");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.KodDecyzji)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kodDecyzji");
            entity.Property(e => e.Kolor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kolor");
            entity.Property(e => e.KosztyZastepstwaEgzekucyjnego)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KosztyZastepstwaProcesowego)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kosztyZastepstwaProcesowego");
            entity.Property(e => e.Kwota1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kwota1");
            entity.Property(e => e.Kwota2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kwota2");
            entity.Property(e => e.Kwota3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kwota3");
            entity.Property(e => e.Kwota4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kwota4");
            entity.Property(e => e.KwotaPozostalaDoZaplaty)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kwotaPozostalaDoZaplaty");
            entity.Property(e => e.Miasto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("miasto");
            entity.Property(e => e.NrKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nr_konta");
            entity.Property(e => e.NrMandatu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nr_mandatu");
            entity.Property(e => e.Numer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numer");
            entity.Property(e => e.OplataSadowa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oplataSadowa");
            entity.Property(e => e.ProwadzacySprawe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowadzacySprawe");
            entity.Property(e => e.Przydzial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("przydzial");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
            entity.Property(e => e.SygnaturaNakazuZaplaty)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnaturaNakazuZaplaty");
            entity.Property(e => e.SygnaturaPostepowaniaEgzekucyjnego)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ulica");
            entity.Property(e => e.Wplata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wplata");
            entity.Property(e => e.Zaliczki)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zaliczki");
        });

        modelBuilder.Entity<Odsetki>(entity =>
        {
            entity.ToTable("Odsetki");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<P>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("p");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasIndex(e => e.EventId, "idx_Payments_notnull")
                .IsUnique()
                .HasFilter("([eventId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.IsPlaned, e.Date }, "missing_index_9944_9943").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountIn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accountIn");
            entity.Property(e => e.AccountOut)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accountOut");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.IsPlaned).HasColumnName("isPlaned");
            entity.Property(e => e.Recipient)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recipient");
            entity.Property(e => e.Sender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sender");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");

            entity.HasOne(d => d.Event).WithOne(p => p.Payment)
                .HasForeignKey<Payment>(d => d.EventId)
                .HasConstraintName("FK_Payments_Events");
        });

        modelBuilder.Entity<PaymentsForFine>(entity =>
        {
            entity.ToTable("PaymentsForFine");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ammount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammount");
            entity.Property(e => e.FineId).HasColumnName("fineId");
            entity.Property(e => e.Interest)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("interest");
            entity.Property(e => e.Koszty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("koszty");
            entity.Property(e => e.PaymentsId).HasColumnName("paymentsId");

            entity.HasOne(d => d.Fine).WithMany(p => p.PaymentsForFines)
                .HasForeignKey(d => d.FineId)
                .HasConstraintName("FK_PaymentsForFine_Fine");

            entity.HasOne(d => d.Payments).WithMany(p => p.PaymentsForFines)
                .HasForeignKey(d => d.PaymentsId)
                .HasConstraintName("FK_PaymentsForFine_Payments");
        });

        modelBuilder.Entity<Pe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pes");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.Signatyres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("signatyres");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasIndex(e => e.Sha1, "IX_Persons").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsReturned).HasColumnName("isReturned");
            entity.Property(e => e.NextDate)
                .HasColumnType("datetime")
                .HasColumnName("nextDate");
            entity.Property(e => e.PastPersonId).HasColumnName("pastPersonId");
            entity.Property(e => e.Sha1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHA1");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.PastPerson).WithMany(p => p.InversePastPerson)
                .HasForeignKey(d => d.PastPersonId)
                .HasConstraintName("FK_Persons_Persons");
        });

        modelBuilder.Entity<Pes2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pes2");

            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pesel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pesel");

            entity.Property(e => e.Pesel1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PeseleN>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("peseleN");

            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Kod pocztowy");
            entity.Property(e => e.KwotaPoKomorniku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Kwota po komorniku");
            entity.Property(e => e.Miejscowość)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NazwaDłużnika)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nazwa dłużnika");
            entity.Property(e => e.NumerKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numer konta");
            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.SumaOdsetek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Suma odsetek");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tytułem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WPS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("W P S ");
            entity.Property(e => e.WPSSumaOdsetek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("W P S  + suma odsetek");
        });

        modelBuilder.Entity<Pezypisane30112018>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pezypisane_30_11_2018");

            entity.Property(e => e.IdSprawy)
                .HasMaxLength(255)
                .HasColumnName("ID sprawy");
            entity.Property(e => e.NowyProwadzacy)
                .HasMaxLength(255)
                .HasColumnName("nowy prowadzacy");
            entity.Property(e => e.StaryProwadzacy)
                .HasMaxLength(255)
                .HasColumnName("stary prowadzacy");
        });

        modelBuilder.Entity<PhoneNumber>(entity =>
        {
            entity.HasIndex(e => e.PersonId, "AS_NonClusteredIndex-20190417-140433").HasFillFactor(90);

            entity.HasIndex(e => e.Number, "IX_PhoneNumbers").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Person).WithMany(p => p.PhoneNumbers)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK_PhoneNumbers_Persons");
        });

        modelBuilder.Entity<Pko>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PKOes");

            entity.HasIndex(e => e.IdAkt, "IX_PKOes").IsUnique();

            entity.HasIndex(e => e.IdPodmiotu, "IX_PKOes_1").HasFillFactor(90);

            entity.HasIndex(e => e.PrzekazanaOd, "IX_PKOes_2").HasFillFactor(90);

            entity.HasIndex(e => e.CaseId, "NonClusteredIndex-20170126-080044").HasFillFactor(90);

            entity.Property(e => e.CaseId).HasColumnName("caseID");
            entity.Property(e => e.IdAkt).HasColumnName("idAkt");
            entity.Property(e => e.IdPodmiotu).HasColumnName("idPodmiotu");
            entity.Property(e => e.PrzekazanaOd)
                .HasColumnType("datetime")
                .HasColumnName("przekazanaOd");

            entity.HasOne(d => d.Case).WithMany()
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_PKOes_Case");
        });

        modelBuilder.Entity<PkpintercitySyg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pkpintercity_syg");

            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 1");
            entity.Property(e => e.Column10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 10");
            entity.Property(e => e.Column11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 11");
            entity.Property(e => e.Column12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 12");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 2");
            entity.Property(e => e.Column3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 3");
            entity.Property(e => e.Column4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 4");
            entity.Property(e => e.Column5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 5");
            entity.Property(e => e.Column6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 6");
            entity.Property(e => e.Column7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 7");
            entity.Property(e => e.Column8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 8");
            entity.Property(e => e.Column9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 9");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Podzial2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("podzial2");

            entity.Property(e => e.Nowy)
                .HasMaxLength(255)
                .HasColumnName("nowy");
            entity.Property(e => e.Prowadzący).HasMaxLength(255);
            entity.Property(e => e.Sygnatura).HasMaxLength(255);
        });

        modelBuilder.Entity<Postanowienium>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseID");
            entity.Property(e => e.DataOrzeczenia)
                .HasColumnType("datetime")
                .HasColumnName("dataOrzeczenia");
            entity.Property(e => e.DataWplywu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dataWplywu");
            entity.Property(e => e.Dokument)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("dokument");
            entity.Property(e => e.EpuId).HasColumnName("epuID");
            entity.Property(e => e.NazwaDecyzji)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nazwaDecyzji");
            entity.Property(e => e.Powod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("powod");
            entity.Property(e => e.Pozwany)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pozwany");
            entity.Property(e => e.Sad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sad");
            entity.Property(e => e.Sedzia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sedzia");
            entity.Property(e => e.SiganturePow)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("siganturePow");
            entity.Property(e => e.Signature)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("signature");
            entity.Property(e => e.StatPostanowienia).HasColumnName("statPostanowienia");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.ToDoComment)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("toDoComment");
            entity.Property(e => e.ToDoDate)
                .HasColumnType("datetime")
                .HasColumnName("toDoDate");
            entity.Property(e => e.Tresc)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("tresc");

            entity.HasOne(d => d.Case).WithMany(p => p.Postanowienia)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_Postanowienia_Case");
        });

        modelBuilder.Entity<PowerbiOdzyskiNowePortfele>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("powerbi_odzyskiNowePortfele");

            entity.Property(e => e.DataWplaty)
                .HasColumnType("datetime")
                .HasColumnName("Data wplaty");
            entity.Property(e => e.Kwota).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NazwaPakietu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nazwa pakietu");
            entity.Property(e => e.NumerSprawyWCrm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Numer sprawy w CRM");
        });

        modelBuilder.Entity<PowerbiOdzyskiStarePortfele>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("powerbi_odzyskiStarePortfele");

            entity.Property(e => e.DataWplaty)
                .HasColumnType("datetime")
                .HasColumnName("Data wplaty");
            entity.Property(e => e.Kwota).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NazwaPakietu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nazwa pakietu");
            entity.Property(e => e.NumerSprawyWCrm)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Numer sprawy w CRM");
        });

        modelBuilder.Entity<PowerbiV1WplatyNaZlecenie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("powerbi_v1_wplatyNaZlecenie");

            entity.Property(e => e.DataWplaty)
                .HasColumnType("datetime")
                .HasColumnName("Data wplaty");
            entity.Property(e => e.DataWystawienia)
                .HasColumnType("datetime")
                .HasColumnName("Data wystawienia");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdKlienta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Id klienta");
            entity.Property(e => e.IloscDniDoPrzedawnienia).HasColumnName("Ilosc dni do przedawnienia");
            entity.Property(e => e.KwotaWpłaty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Kwota wpłaty");
            entity.Property(e => e.NazwaPakietu)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Nazwa pakietu");
            entity.Property(e => e.ProwizjaDlaNieprzedawnionych)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Prowizja dla nieprzedawnionych");
            entity.Property(e => e.ProwizjaDlaPrzedawnionych)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Prowizja dla przedawnionych");
        });

        modelBuilder.Entity<Projectpoland>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("projectpoland");

            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.Expr1)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Kwota).HasColumnName("kwota");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnName("PESEL");
            entity.Property(e => e.Sha1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHA1");
            entity.Property(e => e.Signatures)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("signatures");
            entity.Property(e => e.StateId).HasColumnName("stateID");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<ProvisionMarkerDss>(entity =>
        {
            entity.HasKey(e => new { e.OwnerScopeLocalId, e.ObjectId }).HasName("PK_DataSync.provision_marker_dss");

            entity.ToTable("provision_marker_dss", "DataSync");

            entity.Property(e => e.OwnerScopeLocalId).HasColumnName("owner_scope_local_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ProvisionDatetime)
                .HasColumnType("datetime")
                .HasColumnName("provision_datetime");
            entity.Property(e => e.ProvisionLocalPeerKey).HasColumnName("provision_local_peer_key");
            entity.Property(e => e.ProvisionScopeLocalId).HasColumnName("provision_scope_local_id");
            entity.Property(e => e.ProvisionScopePeerKey).HasColumnName("provision_scope_peer_key");
            entity.Property(e => e.ProvisionScopePeerTimestamp).HasColumnName("provision_scope_peer_timestamp");
            entity.Property(e => e.ProvisionTimestamp).HasColumnName("provision_timestamp");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("version");
        });

        modelBuilder.Entity<Przewozy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("przewozy");

            entity.Property(e => e.Koszty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TytuEm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tytuem");
        });

        modelBuilder.Entity<Przyd30062015>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("przyd30_06_2015");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data");
            entity.Property(e => e.Ids)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ids");
            entity.Property(e => e.Kolorem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kolorem");
            entity.Property(e => e.Komu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("komu");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
            entity.Property(e => e.Uzytkownik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uzytkownik");
        });

        modelBuilder.Entity<Przyd300620151422>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("przyd30_06_2015_14_22");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data");
            entity.Property(e => e.Ids)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ids");
            entity.Property(e => e.Kolorem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kolorem");
            entity.Property(e => e.Komu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("komu");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
            entity.Property(e => e.Uzytkownik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uzytkownik");
        });

        modelBuilder.Entity<Przydzialy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Przydzialy");

            entity.Property(e => e.Komu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("komu");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
            entity.Property(e => e._20150717000000000)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("2015-07-17 00 00 00 000");
        });

        modelBuilder.Entity<Pub11>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pub11");

            entity.Property(e => e.Dku)
                .HasColumnType("datetime")
                .HasColumnName("dku");
            entity.Property(e => e.Dzw)
                .HasColumnType("datetime")
                .HasColumnName("dzw");
            entity.Property(e => e.Idodp)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("idodp");
            entity.Property(e => e.Koszt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("koszt");
            entity.Property(e => e.Mxp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mxp");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(500)
                .HasColumnName("nazwa");
            entity.Property(e => e.Prowizja).HasColumnName("prowizja");
            entity.Property(e => e.Prowizja2).HasColumnName("prowizja2");
            entity.Property(e => e.Prowizja3).HasColumnName("prowizja3");
            entity.Property(e => e.Wzob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wzob");
            entity.Property(e => e.Wzon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wzon");
        });

        modelBuilder.Entity<Pub2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pub2");

            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 2");
            entity.Property(e => e.Column3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 3");
            entity.Property(e => e.Column5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 5");
            entity.Property(e => e.Column6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 6");
            entity.Property(e => e.Dku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dku");
            entity.Property(e => e.Dtt)
                .HasColumnType("datetime")
                .HasColumnName("dtt");
            entity.Property(e => e.Dtt1)
                .HasColumnType("datetime")
                .HasColumnName("dtt1");
            entity.Property(e => e.Dzw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dzw");
            entity.Property(e => e.Koszt).HasColumnName("koszt");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<Pub22>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pub22");

            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 2");
            entity.Property(e => e.Column3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 3");
            entity.Property(e => e.Column5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 5");
            entity.Property(e => e.Column6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Column 6");
            entity.Property(e => e.Dku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dku");
            entity.Property(e => e.Dtt)
                .HasColumnType("datetime")
                .HasColumnName("dtt");
            entity.Property(e => e.Dtt1)
                .HasColumnType("datetime")
                .HasColumnName("dtt1");
            entity.Property(e => e.Dzw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dzw");
            entity.Property(e => e.Koszt).HasColumnName("koszt");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(500)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<Pw2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pw2");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KosztySądowe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Koszty sądowe");
            entity.Property(e => e.Kwota)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Miejscowość)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NazwiskoIImię)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nazwisko i imię");
            entity.Property(e => e.NrElementuSprawy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nr elementu sprawy");
            entity.Property(e => e.NumerKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numer Konta");
            entity.Property(e => e.Psygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PSygnatura");
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pw3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pw3");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KosztySądowe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Koszty sądowe");
            entity.Property(e => e.Kwota)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Miejscowość)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NazwiskoIImię)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nazwisko i imię");
            entity.Property(e => e.NrElementuSprawy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nr elementu sprawy");
            entity.Property(e => e.NumerKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numer Konta");
            entity.Property(e => e.Psygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PSygnatura");
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reprezentacja>(entity =>
        {
            entity.ToTable("Reprezentacja");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.LocalNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("localNumber");
            entity.Property(e => e.Name)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Nip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NIP");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.Pesel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.SecoundName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("street");
            entity.Property(e => e.Umocowanie)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("umocowanie");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("zip");
            entity.Property(e => e.ZipName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("zipName");
        });

        modelBuilder.Entity<RequestsCase>(entity =>
        {
            entity.ToTable("RequestsCase");

            entity.HasIndex(e => e.RequestPaymentsId, "AS_NonClusteredIndex-20190416-110613").HasFillFactor(90);

            entity.HasIndex(e => e.CaseId, "AS_NonClusteredIndex-20190416-113400").HasFillFactor(90);

            entity.HasIndex(e => e.EventId, "idx_RequestsCase_notnull")
                .IsUnique()
                .HasFilter("([eventId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AmmountOfTheFullCost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ammountOfTheFullCost");
            entity.Property(e => e.AmountOnRequest)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amountOnRequest");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.Interst)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("interst");
            entity.Property(e => e.Kek)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kek");
            entity.Property(e => e.Kos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kos");
            entity.Property(e => e.Kpe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kpe");
            entity.Property(e => e.Kpp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kpp");
            entity.Property(e => e.Kps)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kps");
            entity.Property(e => e.Kzp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kzp");
            entity.Property(e => e.RequestPaymentsId).HasColumnName("requestPaymentsId");

            entity.HasOne(d => d.Case).WithMany(p => p.RequestsCases)
                .HasForeignKey(d => d.CaseId)
                .HasConstraintName("FK_RequestsCase_RequestsCase");

            entity.HasOne(d => d.Event).WithOne(p => p.RequestsCase)
                .HasForeignKey<RequestsCase>(d => d.EventId)
                .HasConstraintName("FK_RequestsCase_Events");

            entity.HasOne(d => d.RequestPayments).WithMany(p => p.RequestsCases)
                .HasForeignKey(d => d.RequestPaymentsId)
                .HasConstraintName("FK_RequestsCase_RequestsPayments");
        });

        modelBuilder.Entity<RequestsPayment>(entity =>
        {
            entity.HasIndex(e => e.Signature, "NonClusteredIndex-20190509-122421").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankAcountNr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankAcountNr");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateOfPayment)
                .HasColumnType("date")
                .HasColumnName("dateOfPayment");
            entity.Property(e => e.Nr).HasColumnName("nr");
            entity.Property(e => e.Signature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("signature");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<SchemaInfoDss>(entity =>
        {
            entity.HasKey(e => new { e.SchemaMajorVersion, e.SchemaMinorVersion }).HasName("PK_DataSync.schema_info_dss");

            entity.ToTable("schema_info_dss", "DataSync");

            entity.Property(e => e.SchemaMajorVersion).HasColumnName("schema_major_version");
            entity.Property(e => e.SchemaMinorVersion).HasColumnName("schema_minor_version");
            entity.Property(e => e.SchemaExtendedInfo)
                .HasMaxLength(100)
                .HasColumnName("schema_extended_info");
        });

        modelBuilder.Entity<ScopeConfigDss>(entity =>
        {
            entity.HasKey(e => e.ConfigId).HasName("PK_DataSync.scope_config_dss");

            entity.ToTable("scope_config_dss", "DataSync");

            entity.Property(e => e.ConfigId)
                .ValueGeneratedNever()
                .HasColumnName("config_id");
            entity.Property(e => e.ConfigData)
                .HasColumnType("xml")
                .HasColumnName("config_data");
            entity.Property(e => e.ScopeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("scope_status");
        });

        modelBuilder.Entity<ScopeInfoDss>(entity =>
        {
            entity.HasKey(e => e.SyncScopeName).HasName("PK_DataSync.scope_info_dss");

            entity.ToTable("scope_info_dss", "DataSync");

            entity.Property(e => e.SyncScopeName)
                .HasMaxLength(100)
                .HasColumnName("sync_scope_name");
            entity.Property(e => e.ScopeConfigId).HasColumnName("scope_config_id");
            entity.Property(e => e.ScopeId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("scope_id");
            entity.Property(e => e.ScopeLocalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("scope_local_id");
            entity.Property(e => e.ScopeRestoreCount).HasColumnName("scope_restore_count");
            entity.Property(e => e.ScopeSyncKnowledge).HasColumnName("scope_sync_knowledge");
            entity.Property(e => e.ScopeTimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("scope_timestamp");
            entity.Property(e => e.ScopeTombstoneCleanupKnowledge).HasColumnName("scope_tombstone_cleanup_knowledge");
            entity.Property(e => e.ScopeUserComment).HasColumnName("scope_user_comment");
        });

        modelBuilder.Entity<Signature>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("signatures");

            entity.Property(e => e.CaseAmmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("case_ammount");
            entity.Property(e => e.CaseSignature)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("case_signature");
            entity.Property(e => e.DataPodpUmowy)
                .HasColumnType("date")
                .HasColumnName("data_podp_umowy");
            entity.Property(e => e.FineIds)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FineIDs");
            entity.Property(e => e.Mandaty)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("mandaty");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PaymAmmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("paym_ammount");
            entity.Property(e => e.PaymDate)
                .HasColumnType("datetime")
                .HasColumnName("paym_date");
            entity.Property(e => e.RequestAmmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHA");
            entity.Property(e => e.Signature1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("signature");
            entity.Property(e => e.Stateid).HasColumnName("stateid");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.ToTable("SMS");

            entity.HasIndex(e => e.EventId, "idx_SMS_notnull")
                .IsUnique()
                .HasFilter("([eventId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contents)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("contents");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DateSended)
                .HasColumnType("datetime")
                .HasColumnName("dateSended");
            entity.Property(e => e.EventId).HasColumnName("eventId");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StatusDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statusDesc");

            entity.HasOne(d => d.Event).WithOne(p => p.Sm)
                .HasForeignKey<Sm>(d => d.EventId)
                .HasConstraintName("FK_SMS_Events");
        });

        modelBuilder.Entity<Smstemplate>(entity =>
        {
            entity.ToTable("SMSTemplates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IsAnkieta).HasColumnName("isAnkieta");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Text)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("text");
        });

        modelBuilder.Entity<SortVisibleCase>(entity =>
        {
            entity.HasIndex(e => e.ContractFilesId, "idx_SortVisibleCases2_notnull")
                .IsUnique()
                .HasFilter("([contractFilesId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.HasIndex(e => e.BagsTypeId, "idx_SortVisibleCases_notnull")
                .IsUnique()
                .HasFilter("([bagsTypeId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BagsTypeId).HasColumnName("bagsTypeId");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("columnName");
            entity.Property(e => e.ContractFilesId).HasColumnName("contractFilesId");
            entity.Property(e => e.SortNumber).HasColumnName("sortNumber");

            entity.HasOne(d => d.BagsType).WithOne(p => p.SortVisibleCase)
                .HasForeignKey<SortVisibleCase>(d => d.BagsTypeId)
                .HasConstraintName("FK_SortVisibleCases_BagsType");

            entity.HasOne(d => d.ContractFiles).WithOne(p => p.SortVisibleCase)
                .HasForeignKey<SortVisibleCase>(d => d.ContractFilesId)
                .HasConstraintName("FK_SortVisibleCases_ContratsFiles");
        });

        modelBuilder.Entity<StareMiasto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stareMiasto");

            entity.Property(e => e.NumerKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numer konta");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status1)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<StopyLombardowe>(entity =>
        {
            entity.ToTable("StopyLombardowe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Value)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<SystemLog>(entity =>
        {
            entity.ToTable("SystemLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Text)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("text");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.SystemLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SystemLog_Users");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity.ToTable("temp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sygnatura");
        });

        modelBuilder.Entity<TempPlaned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempPlaned");

            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.PlanedText)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("planedText");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .IsUnicode(false)
                .HasColumnName("data");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("path");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<TmpMojeSprawy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpMojeSprawy");

            entity.Property(e => e.DataPrawomocnosci)
                .HasColumnType("datetime")
                .HasColumnName("dataPrawomocnosci");
            entity.Property(e => e.DataWplywu)
                .HasColumnType("datetime")
                .HasColumnName("dataWplywu");
            entity.Property(e => e.DataZakreslenia)
                .HasColumnType("datetime")
                .HasColumnName("dataZakreslenia");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KwotaSporu)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("kwotaSporu");
            entity.Property(e => e.RolaWsprawie)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("rolaWSprawie");
            entity.Property(e => e.StanSprawy)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("stanSprawy");
            entity.Property(e => e.StronyWsprawie)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("stronyWSprawie");
            entity.Property(e => e.SygnaturaSprawy)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("sygnaturaSprawy");
            entity.Property(e => e.SygnaturaWgPowoda)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("sygnaturaWgPowoda");
        });

        modelBuilder.Entity<Umowb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("umowb");

            entity.Property(e => e.DataKońcaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data końca umowy");
            entity.Property(e => e.DataZawarciaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data zawarcia umowy");
            entity.Property(e => e.IiiProwizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("III prowizja");
            entity.Property(e => e.IlośćDniOdDatyPrzedawnienia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilość dni od daty przedawnienia");
            entity.Property(e => e.KosztZakupu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("koszt zakupu");
            entity.Property(e => e.MaksymalnaZapłata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maksymalna zapłata");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Prowizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja");
            entity.Property(e => e.ProwizjaPoPrzedawnieniu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja po przedawnieniu");
            entity.Property(e => e.WindykacjaZaOdsetkiBrutto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki brutto");
            entity.Property(e => e.WindykacjaZaOdsetkiNetto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki netto");
        });

        modelBuilder.Entity<Umowb2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("umowb2");

            entity.Property(e => e.DataKońcaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data końca umowy");
            entity.Property(e => e.DataZawarciaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data zawarcia umowy");
            entity.Property(e => e.IiiProwizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("III prowizja");
            entity.Property(e => e.IlośćDniOdDatyPrzedawnienia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilość dni od daty przedawnienia");
            entity.Property(e => e.KosztZakupu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("koszt zakupu");
            entity.Property(e => e.MaksymalnaZapłata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maksymalna zapłata");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Prowizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja");
            entity.Property(e => e.ProwizjaPoPrzedawnieniu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja po przedawnieniu");
            entity.Property(e => e.WindykacjaZaOdsetkiBrutto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki brutto");
            entity.Property(e => e.WindykacjaZaOdsetkiNetto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki netto");
        });

        modelBuilder.Entity<Umowb2c1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("umowb2c1");

            entity.Property(e => e.DataKońcaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data końca umowy");
            entity.Property(e => e.DataZawarciaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data zawarcia umowy");
            entity.Property(e => e.IiiProwizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("III prowizja");
            entity.Property(e => e.IlośćDniOdDatyPrzedawnienia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilość dni od daty przedawnienia");
            entity.Property(e => e.KosztZakupu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("koszt zakupu");
            entity.Property(e => e.MaksymalnaZapłata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maksymalna zapłata");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Prowizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja");
            entity.Property(e => e.ProwizjaPoPrzedawnieniu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja po przedawnieniu");
            entity.Property(e => e.WindykacjaZaOdsetkiBrutto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki brutto");
            entity.Property(e => e.WindykacjaZaOdsetkiNetto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki netto");
        });

        modelBuilder.Entity<Umowb3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("umowb3");

            entity.Property(e => e.DataKońcaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data końca umowy");
            entity.Property(e => e.DataZawarciaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data zawarcia umowy");
            entity.Property(e => e.IiiProwizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("III prowizja");
            entity.Property(e => e.IlośćDniOdDatyPrzedawnienia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilość dni od daty przedawnienia");
            entity.Property(e => e.KosztZakupu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("koszt zakupu");
            entity.Property(e => e.MaksymalnaZapłata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maksymalna zapłata");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Prowizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja");
            entity.Property(e => e.ProwizjaPoPrzedawnieniu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja po przedawnieniu");
            entity.Property(e => e.WindykacjaZaOdsetkiBrutto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki brutto");
            entity.Property(e => e.WindykacjaZaOdsetkiNetto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki netto");
        });

        modelBuilder.Entity<Umowyb2c>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("umowyb2c");

            entity.Property(e => e.DataKońcaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data końca umowy");
            entity.Property(e => e.DataZawarciaUmowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("data zawarcia umowy");
            entity.Property(e => e.IiiProwizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("III prowizja");
            entity.Property(e => e.IlośćDniOdDatyPrzedawnienia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilość dni od daty przedawnienia");
            entity.Property(e => e.KosztZakupu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("koszt zakupu");
            entity.Property(e => e.MaksymalnaZapłata)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maksymalna zapłata");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Prowizja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja");
            entity.Property(e => e.ProwizjaPoPrzedawnieniu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prowizja po przedawnieniu");
            entity.Property(e => e.WindykacjaZaOdsetkiBrutto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki brutto");
            entity.Property(e => e.WindykacjaZaOdsetkiNetto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("windykacja za odsetki netto");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Desription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("desription");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emailAddress");
            entity.Property(e => e.EmailTemplateId).HasColumnName("emailTemplateId");
            entity.Property(e => e.EmmailPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emmailPassword");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.InDashboard).HasColumnName("inDashboard");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsSystem).HasColumnName("isSystem");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PasswordDate)
                .HasColumnType("date")
                .HasColumnName("passwordDate");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<UserConfiguration>(entity =>
        {
            entity.ToTable("UserConfiguration");

            entity.HasIndex(e => e.UserId, "idx_UserConfiguration_notnull")
                .IsUnique()
                .HasFilter("([userId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Config)
                .HasColumnType("xml")
                .HasColumnName("config");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithOne(p => p.UserConfiguration)
                .HasForeignKey<UserConfiguration>(d => d.UserId)
                .HasConstraintName("FK_UserConfiguration_Users");
        });

        modelBuilder.Entity<Warrant>(entity =>
        {
            entity.HasIndex(e => e.WarrantSignature, "IX_Warrants").HasFillFactor(90);

            entity.HasIndex(e => e.Number, "IX_Warrants_1").HasFillFactor(90);

            entity.HasIndex(e => e.CaseId, "idx_Warrants_notnull")
                .IsUnique()
                .HasFilter("([caseId] IS NOT NULL)")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaseId).HasColumnName("caseId");
            entity.Property(e => e.ClauseDate)
                .HasColumnType("datetime")
                .HasColumnName("clauseDate");
            entity.Property(e => e.DecisionCode).HasColumnName("decisionCode");
            entity.Property(e => e.EpuId).HasColumnName("EpuID");
            entity.Property(e => e.InterestFreeDays).HasColumnName("interestFreeDays");
            entity.Property(e => e.Kos)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kos");
            entity.Property(e => e.Kzp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("kzp");
            entity.Property(e => e.LegitymacyDate)
                .HasColumnType("datetime")
                .HasColumnName("legitymacyDate");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.RulingDate)
                .HasColumnType("datetime")
                .HasColumnName("rulingDate");
            entity.Property(e => e.WarrantSignature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("warrantSignature");

            entity.HasOne(d => d.Case).WithOne(p => p.Warrant)
                .HasForeignKey<Warrant>(d => d.CaseId)
                .HasConstraintName("FK_Warrants_Warrants");
        });

        modelBuilder.Entity<Wplaty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wplaty");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
        });

        modelBuilder.Entity<WplatyCesje>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wplaty_cesje");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<WplatyCesjePerWindykator>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wplaty_cesje_per_windykator");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<WplatyZleceniaPerWindykator>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wplaty_zlecenia_per_windykator");

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Wysi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wysi");

            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KosztySądowe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Koszty sądowe");
            entity.Property(e => e.Kwota)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Miejscowość)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NazwiskoIImię)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nazwisko i imię");
            entity.Property(e => e.NrElementuSprawy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nr elementu sprawy");
            entity.Property(e => e.NumerKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numer Konta");
            entity.Property(e => e.Psygnatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PSygnatura");
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Yonick1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yonick1");

            entity.Property(e => e.AdresSiedziby1UlicaINumer)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES SIEDZIBY1 (ULICA I NUMER)");
            entity.Property(e => e.AdresSiedziby2KodPocztowyIMiasto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES SIEDZIBY2 (KOD POCZTOWY I MIASTO)");
            entity.Property(e => e.AdresSiedziby3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES SIEDZIBY3");
            entity.Property(e => e.AdresSiedziby4)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES SIEDZIBY4");
            entity.Property(e => e.AdresZamieszkania1UlicaINumer)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES ZAMIESZKANIA1 (ULICA I NUMER)");
            entity.Property(e => e.AdresZamieszkania2KodPocztowyIMiasto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES ZAMIESZKANIA2 (KOD POCZTOWY I MIASTO)");
            entity.Property(e => e.AdresZamieszkania3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES ZAMIESZKANIA3");
            entity.Property(e => e.AdresZamieszkania4)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADRES ZAMIESZKANIA4");
            entity.Property(e => e.DataUrodzenia)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DATA URODZENIA");
            entity.Property(e => e.DataWysłaniaWezwania)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DATA WYSŁANIA WEZWANIA");
            entity.Property(e => e.DataZakończeniaZawieszenia)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DATA ZAKOŃCZENIA ZAWIESZENIA");
            entity.Property(e => e.DrugieImię)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DRUGIE IMIĘ");
            entity.Property(e => e.Ekd)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EKD");
            entity.Property(e => e.IdentyfikatorSprawy)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IDENTYFIKATOR SPRAWY");
            entity.Property(e => e.IdentyfikatorZobowiązania)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IDENTYFIKATOR ZOBOWIĄZANIA");
            entity.Property(e => e.Imię)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IMIĘ");
            entity.Property(e => e.KwotaZadłużenia)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("KWOTA ZADŁUŻENIA");
            entity.Property(e => e.NazwaFirmy)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NAZWA FIRMY");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NAZWISKO");
            entity.Property(e => e.Nip)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NIP");
            entity.Property(e => e.Numer)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NUMER");
            entity.Property(e => e.NumerWRejestrze)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NUMER W REJESTRZE");
            entity.Property(e => e.Obywatelstwo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("OBYWATELSTWO");
            entity.Property(e => e.Operacja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("#OPERACJA");
            entity.Property(e => e.Pesel)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.Regon)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REGON");
            entity.Property(e => e.RodzajDłużnika)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RODZAJ DŁUŻNIKA");
            entity.Property(e => e.Seria)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SERIA");
            entity.Property(e => e.SądRejestrowy)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SĄD REJESTROWY");
            entity.Property(e => e.TerminWymagalności)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TERMIN WYMAGALNOŚCI");
            entity.Property(e => e.TypDokumentuTożsamości)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TYP DOKUMENTU TOŻSAMOŚCI");
            entity.Property(e => e.TytułZobowiązania)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TYTUŁ ZOBOWIĄZANIA");
            entity.Property(e => e.Waluta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("WALUTA");
            entity.Property(e => e.WysokośćZobowiązania)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("WYSOKOŚĆ ZOBOWIĄZANIA");
        });

        modelBuilder.Entity<Zap2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zap2");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Id1).HasColumnName("id1");
            entity.Property(e => e.IsReturned).HasColumnName("isReturned");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");
            entity.Property(e => e.PastPersonId)
                .HasMaxLength(255)
                .HasColumnName("pastPersonId");
            entity.Property(e => e.PersonId).HasColumnName("personId");
            entity.Property(e => e.Sha1)
                .HasMaxLength(255)
                .HasColumnName("SHA1");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Type1)
                .HasMaxLength(255)
                .HasColumnName("type1");
        });

        modelBuilder.Entity<Zeszyt1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Zeszyt1");

            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Kod pocztowy");
            entity.Property(e => e.KwotaPoKomorniku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Kwota po komorniku");
            entity.Property(e => e.Miejscowość)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NazwaDłużnika)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Nazwa dłużnika");
            entity.Property(e => e.NumerKonta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numer konta");
            entity.Property(e => e.Pesel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESEL");
            entity.Property(e => e.SumaOdsetek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Suma odsetek");
            entity.Property(e => e.Sygnatura)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tytułem)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Ulica)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WPS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("W P S ");
            entity.Property(e => e.WPSSumaOdsetek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("W P S  + suma odsetek");
        });

        modelBuilder.Entity<_16092019zmianaProwadzacego>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("16092019ZmianaProwadzacego");

            entity.Property(e => e.IdSprawy)
                .HasMaxLength(255)
                .HasColumnName("ID sprawy");
            entity.Property(e => e.NowyProwadzacy)
                .HasMaxLength(255)
                .HasColumnName("nowy prowadzacy");
            entity.Property(e => e.StaryProwadzacy)
                .HasMaxLength(255)
                .HasColumnName("stary prowadzacy");
        });

        modelBuilder.Entity<_18092019zmianaProwadzacych>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("18092019ZmianaProwadzacych");

            entity.Property(e => e.IdSprawy)
                .HasMaxLength(255)
                .HasColumnName("ID sprawy");
            entity.Property(e => e.NowyProwadzacy)
                .HasMaxLength(255)
                .HasColumnName("nowy prowadzacy");
            entity.Property(e => e.StaryProwadzacy)
                .HasMaxLength(255)
                .HasColumnName("stary prowadzacy");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
