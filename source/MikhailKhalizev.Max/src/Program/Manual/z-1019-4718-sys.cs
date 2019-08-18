using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4718-4def7ee9")]
        public void /* sys */ Method_1019_4718()
        {
            RawProgramMain.DosTimer.Start();

            mov(memd_a32[ds, 0x1020_bc5c], 1);
            retd();

#if false

            ii(0x1019_4718, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4719, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_471a, 1); pushd(edx);                             /* push edx */
            ii(0x1019_471b, 1); pushd(esi);                             /* push esi */

            ii(0x1019_471c, 2); mov(ah, 0x2c);                          /* mov ah, 0x2c */
            ii(0x1019_471e, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_4720, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4722, 2); mov(al, dh);                            /* mov al, dh */
            ii(0x1019_4724, 2); mov(ebx, eax);                          /* mov ebx, eax */

            Console.WriteLine("Wait 1 sec.");

        l_0x1019_4726:
            ii(0x1019_4726, 2); mov(ah, 0x2c);                          /* mov ah, 0x2c */
            ii(0x1019_4728, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_472a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_472c, 2); mov(al, dh);                            /* mov al, dh */
            ii(0x1019_472e, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1019_4730, 2); if(jzd(0x1019_4726, -0xc)) goto l_0x1019_4726; /* jz 0x10194726 */
            ii(0x1019_4732, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1019_4734, 2); mov(bl, al);                            /* mov bl, al */

            Console.WriteLine("Wait 1 sec.");

        l_0x1019_4736:
            ii(0x1019_4736, 2); mov(ah, 0x2c);                          /* mov ah, 0x2c */
            ii(0x1019_4738, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_473a, 1); inc(esi);                               /* inc esi */
            ii(0x1019_473b, 2); cmp(bl, dh);                            /* cmp bl, dh */
            ii(0x1019_473d, 2); if(jzd(0x1019_4736, -0x9)) goto l_0x1019_4736; /* jz 0x10194736 */

            Console.WriteLine("Continue.");

            ii(0x1019_473f, 6); mov(memd_a32[ds, 0x1020_bc5c], esi);    /* mov [0x1020bc5c], esi */

            ii(0x1019_4745, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4746, 1); popd(edx);                              /* pop edx */
            ii(0x1019_4747, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4748, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4749, 1); retd(); return;                         /* ret */
#endif
        }
    }
}
