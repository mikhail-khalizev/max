using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_05f8-1cf84e74")]
        public void Method_1008_05f8()
        {
            ii(0x1008_05f8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_05fd, 5); calld(Definitions.sys_check_available_stack_size, 0xe_5750); /* call 0x10165d52 */
            ii(0x1008_0602, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_0603, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_0604, 1); pushd(edx);                             /* push edx */
            ii(0x1008_0605, 1); pushd(esi);                             /* push esi */
            ii(0x1008_0606, 1); pushd(edi);                             /* push edi */
            ii(0x1008_0607, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_0608, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_060a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_0610, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_0613, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0616, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1008_0619, 5); calld(0x1007_6b90, -0x9a8e);            /* call 0x10076b90 */
            ii(0x1008_061e, 1); cwde();                                 /* cwde */
            ii(0x1008_061f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0621, 2); if(jnzd(0x1008_062d, 0xa)) goto l_0x1008_062d; /* jnz 0x1008062d */
            ii(0x1008_0623, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0626, 5); calld(0x1007_f659, -0xfd2);             /* call 0x1007f659 */
            ii(0x1008_062b, 2); jmpd(0x1008_0635, 0x8); goto l_0x1008_0635; /* jmp 0x10080635 */
        l_0x1008_062d:
            ii(0x1008_062d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0630, 5); calld(0x1007_f76b, -0xeca);             /* call 0x1007f76b */
        l_0x1008_0635:
            ii(0x1008_0635, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0637, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_0638, 1); popd(edi);                              /* pop edi */
            ii(0x1008_0639, 1); popd(esi);                              /* pop esi */
            ii(0x1008_063a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_063b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_063c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_063d, 1); retd();                                 /* ret */
        }
    }
}
