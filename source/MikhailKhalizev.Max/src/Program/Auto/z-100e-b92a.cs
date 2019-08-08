using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("905df42e-1ae9-47a9-95d1-99cc73810a70")]
        public void Method_100e_b92a()
        {
            ii(0x100e_b92a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b92f, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a41e); /* call 0x10165d52 */
            ii(0x100e_b934, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b935, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b936, 1); pushd(edx);                             /* push edx */
            ii(0x100e_b937, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b938, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b939, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b93a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b93c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_b942, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_b945, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b948, 4); cmp(memb_a32[ds, eax + 0x32], 0);       /* cmp byte [eax+0x32], 0x0 */
            ii(0x100e_b94c, 2); if(jzd(0x100e_b958, 0xa)) goto l_0x100e_b958; /* jz 0x100eb958 */
            ii(0x100e_b94e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b951, 5); calld(0x100e_b58f, -0x3c7);             /* call 0x100eb58f */
            ii(0x100e_b956, 2); jmpd(0x100e_b974, 0x1c); goto l_0x100e_b974; /* jmp 0x100eb974 */
        l_0x100e_b958:
            ii(0x100e_b958, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b95b, 3); mov(eax, memd_a32[ds, eax + 0x2a]);     /* mov eax, [eax+0x2a] */
            ii(0x100e_b95e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_b961, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_b963, 2); if(jzd(0x100e_b974, 0xf)) goto l_0x100e_b974; /* jz 0x100eb974 */
            ii(0x100e_b965, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b968, 4); dec(memw_a32[ds, eax + 0x2c]);          /* dec word [eax+0x2c] */
            ii(0x100e_b96c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b96f, 5); calld(0x100e_b84d, -0x127);             /* call 0x100eb84d */
        l_0x100e_b974:
            ii(0x100e_b974, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b976, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b977, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b978, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b979, 1); popd(edx);                              /* pop edx */
            ii(0x100e_b97a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b97b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b97c, 1); retd(); return;                         /* ret */
        }
    }
}
