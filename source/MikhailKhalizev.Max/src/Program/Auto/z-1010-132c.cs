using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d6a23ecb-1dca-4087-a03f-39fbc78120b0")]
        public void Method_1010_132c()
        {
            ii(0x1010_132c, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1010_1331, 5); calld(Definitions.sys_check_available_stack_size, 0x64a1c); /* call 0x10165d52 */
            ii(0x1010_1336, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_1337, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_1338, 1); pushd(edx);                             /* push edx */
            ii(0x1010_1339, 1); pushd(esi);                             /* push esi */
            ii(0x1010_133a, 1); pushd(edi);                             /* push edi */
            ii(0x1010_133b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_133c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_133e, 6); sub(esp, 0);                            /* sub esp, 0x0 */
        l_0x1010_1344:
            ii(0x1010_1344, 7); mov(memb_a32[ds, 0x101c_3914], 0x1);    /* mov byte [0x101c3914], 0x1 */
            ii(0x1010_134b, 5); calld(0x100f_963d, -0x7d13);            /* call 0x100f963d */
            ii(0x1010_1350, 7); cmp(memb_a32[ds, 0x101c_3913], 0);      /* cmp byte [0x101c3913], 0x0 */
            ii(0x1010_1357, 2); if(jzd(0x1010_1362, 0x9)) goto l_0x1010_1362; /* jz 0x10101362 */
            ii(0x1010_1359, 7); cmp(memb_a32[ds, 0x101c_3914], 0);      /* cmp byte [0x101c3914], 0x0 */
            ii(0x1010_1360, 2); if(jnzd(0x1010_1364, 0x2)) goto l_0x1010_1364; /* jnz 0x10101364 */
        l_0x1010_1362:
            ii(0x1010_1362, 2); jmpd(0x1010_1366, 0x2); goto l_0x1010_1366; /* jmp 0x10101366 */
        l_0x1010_1364:
            ii(0x1010_1364, 2); jmpd(0x1010_1344, -0x22); goto l_0x1010_1344; /* jmp 0x10101344 */
        l_0x1010_1366:
            ii(0x1010_1366, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_1368, 5); calld(0x1010_0efe, -0x46f);             /* call 0x10100efe */
            ii(0x1010_136d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_136e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_136f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_1370, 1); popd(edx);                              /* pop edx */
            ii(0x1010_1371, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_1372, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_1373, 1); retd(); return;                         /* ret */
        }
    }
}
