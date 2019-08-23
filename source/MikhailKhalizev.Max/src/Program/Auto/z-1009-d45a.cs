using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d45a-ebd8bec1")]
        public void Method_1009_d45a()
        {
            ii(0x1009_d45a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_d45f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_88ee); /* call 0x10165d52 */
            ii(0x1009_d464, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_d465, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_d466, 1); pushd(edx);                             /* push edx */
            ii(0x1009_d467, 1); pushd(esi);                             /* push esi */
            ii(0x1009_d468, 1); pushd(edi);                             /* push edi */
            ii(0x1009_d469, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_d46a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d46c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_d472, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_d475, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_d477, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d47a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d47d, 5); calld(0x1013_ad71, 0x9_d8ef);           /* call 0x1013ad71 */
            ii(0x1009_d482, 2); test(al, al);                           /* test al, al */
            ii(0x1009_d484, 2); if(jzd(0x1009_d49b, 0x15)) goto l_0x1009_d49b; /* jz 0x1009d49b */
            ii(0x1009_d486, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d489, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d48c, 5); calld(0x1007_6574, -0x2_6f1d);          /* call 0x10076574 */
            ii(0x1009_d491, 5); calld(0x1015_26ac, 0xb_5216);           /* call 0x101526ac */
            ii(0x1009_d496, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1009_d499, 2); if(jzd(0x1009_d49d, 0x2)) goto l_0x1009_d49d; /* jz 0x1009d49d */
        l_0x1009_d49b:
            ii(0x1009_d49b, 2); jmpd(0x1009_d4a5, 0x8); goto l_0x1009_d4a5; /* jmp 0x1009d4a5 */
        l_0x1009_d49d:
            ii(0x1009_d49d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d4a0, 5); calld(0x1009_e19c, 0xcf7);              /* call 0x1009e19c */
        l_0x1009_d4a5:
            ii(0x1009_d4a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d4a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d4a8, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d4a9, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d4aa, 1); popd(edx);                              /* pop edx */
            ii(0x1009_d4ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_d4ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_d4ad, 1); retd();                                 /* ret */
        }
    }
}
