using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cd83-13652750")]
        public void Method_1008_cd83()
        {
            ii(0x1008_cd83, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_cd85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_cd88, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_cd8b, 5); calld(0x1013_ad71, 0xa_dfe1);           /* call 0x1013ad71 */
            ii(0x1008_cd90, 2); test(al, al);                           /* test al, al */
            ii(0x1008_cd92, 2); if(jzd(0x1008_cdaa, 0x16)) goto l_0x1008_cdaa; /* jz 0x1008cdaa */
            ii(0x1008_cd94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_cd97, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_cd9a, 5); calld(0x1007_6574, -0x1_682b);          /* call 0x10076574 */
            ii(0x1008_cd9f, 5); calld(0x1009_c9a0, 0xfbfc);             /* call 0x1009c9a0 */
            ii(0x1008_cda4, 1); cwde();                                 /* cwde */
            ii(0x1008_cda5, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1008_cda8, 2); if(jgd(0x1008_cdac, 0x2)) goto l_0x1008_cdac; /* jg 0x1008cdac */
        l_0x1008_cdaa:
            ii(0x1008_cdaa, 2); jmpd(0x1008_cdb9, 0xd); goto l_0x1008_cdb9; /* jmp 0x1008cdb9 */
        l_0x1008_cdac:
            ii(0x1008_cdac, 5); mov(edx, StringDefinitions.AtX2Rate);   /* mov edx, 0x101a0557 */
            ii(0x1008_cdb1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_cdb4, 5); calld(Definitions.sys_strcat, 0xd_9178); /* call 0x10165f31 */
        l_0x1008_cdb9:
            ii(0x1008_cdb9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_cdbc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_cdbf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_cdc2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_cdc4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_cdc5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_cdc6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_cdc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_cdc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_cdc9, 1); retd(); return;                         /* ret */
        }
    }
}
