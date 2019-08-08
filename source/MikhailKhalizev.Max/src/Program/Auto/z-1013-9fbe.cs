using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("154aa7eb-3ba5-440e-bc3e-b6b279086053")]
        public void Method_1013_9fbe()
        {
            ii(0x1013_9fbe, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_9fc3, 5); calld(Definitions.sys_check_available_stack_size, 0x2_bd8a); /* call 0x10165d52 */
            ii(0x1013_9fc8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9fc9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9fca, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9fcb, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9fcc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9fcd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9fcf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_9fd5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9fd8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_9fdb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_9fde, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1013_9fe1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_9fe4, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9fe7, 5); calld(0x1013_aa70, 0xa84);              /* call 0x1013aa70 */
            ii(0x1013_9fec, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_9fef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_9ff2, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9ff5, 5); calld(0x1007_6c98, -0xc_3362);          /* call 0x10076c98 */
            ii(0x1013_9ffa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9ffc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9fff, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a002, 5); calld(0x1013_ad71, 0xd6a);              /* call 0x1013ad71 */
            ii(0x1013_a007, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a009, 2); if(jzd(0x1013_a021, 0x16)) goto l_0x1013_a021; /* jz 0x1013a021 */
            ii(0x1013_a00b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_a00e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a011, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a014, 5); calld(0x1013_aa3c, 0xa23);              /* call 0x1013aa3c */
            ii(0x1013_a019, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_a01c, 5); calld(0x1007_6c98, -0xc_3389);          /* call 0x10076c98 */
        l_0x1013_a021:
            ii(0x1013_a021, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_a024, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_a027, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a02a, 5); calld(0x1007_6c98, -0xc_3397);          /* call 0x10076c98 */
            ii(0x1013_a02f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a031, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a032, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a033, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a034, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a035, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a036, 1); retd(); return;                         /* ret */
        }
    }
}
