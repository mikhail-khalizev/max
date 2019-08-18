using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8e4f4f3b-cbba-4c8a-a21d-09cd093183b8")]
        public void Method_1007_ba2c()
        {
            ii(0x1007_ba2c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_ba31, 5); calld(Definitions.sys_check_available_stack_size, 0xe_a31c); /* call 0x10165d52 */
            ii(0x1007_ba36, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ba37, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ba38, 1); pushd(edx);                             /* push edx */
            ii(0x1007_ba39, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ba3a, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ba3b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ba3c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ba3e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_ba44, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_ba47, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ba49, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ba4c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ba4f, 5); calld(0x1013_ad11, 0xb_f2bd);           /* call 0x1013ad11 */
            ii(0x1007_ba54, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ba56, 2); if(jnzd(0x1007_ba71, 0x19)) goto l_0x1007_ba71; /* jnz 0x1007ba71 */
            ii(0x1007_ba58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ba5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ba5d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_ba60, 5); calld(0x1013_ad11, 0xb_f2ac);           /* call 0x1013ad11 */
            ii(0x1007_ba65, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ba67, 2); if(jnzd(0x1007_ba71, 0x8)) goto l_0x1007_ba71; /* jnz 0x1007ba71 */
            ii(0x1007_ba69, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ba6c, 5); calld(0x1007_b91c, -0x155);             /* call 0x1007b91c */
        l_0x1007_ba71:
            ii(0x1007_ba71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ba73, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_ba74, 1); popd(edi);                              /* pop edi */
            ii(0x1007_ba75, 1); popd(esi);                              /* pop esi */
            ii(0x1007_ba76, 1); popd(edx);                              /* pop edx */
            ii(0x1007_ba77, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_ba78, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_ba79, 1); retd(); return;                         /* ret */
        }
    }
}
