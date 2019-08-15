using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a834c4a-6648-4243-8013-c427d1a557b1")]
        public void Method_100e_94f6()
        {
            ii(0x100e_94f6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_94fb, 5); calld(Definitions.sys_check_available_stack_size, 0x7_c852); /* call 0x10165d52 */
            ii(0x100e_9500, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_9501, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_9502, 1); pushd(edx);                             /* push edx */
            ii(0x100e_9503, 1); pushd(esi);                             /* push esi */
            ii(0x100e_9504, 1); pushd(edi);                             /* push edi */
            ii(0x100e_9505, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_9506, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9508, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_950e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_9511, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_9518, 2); jmpd(0x100e_9520, 0x6); goto l_0x100e_9520; /* jmp 0x100e9520 */
        l_0x100e_951a:
            ii(0x100e_951a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_951d, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100e_9520:
            ii(0x100e_9520, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9523, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_9526, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100e_952a, 2); if(jged(0x100e_9546, 0x1a)) goto l_0x100e_9546; /* jge 0x100e9546 */
            ii(0x100e_952c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_9530, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_9533, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_9535, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9538, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100e_953b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_953d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_953f, 5); calld(/* sys */ 0x1016_965c, 0x8_0118); /* call 0x1016965c */
            ii(0x100e_9544, 2); jmpd(0x100e_951a, -0x2c); goto l_0x100e_951a; /* jmp 0x100e951a */
        l_0x100e_9546:
            ii(0x100e_9546, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9549, 4); cmp(memd_a32[ds, eax + 0x4], 0);        /* cmp dword [eax+0x4], 0x0 */
            ii(0x100e_954d, 2); if(jzd(0x100e_955a, 0xb)) goto l_0x100e_955a; /* jz 0x100e955a */
            ii(0x100e_954f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9552, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100e_9555, 5); calld(Definitions.sys_delete, 0x7_ca0a); /* call 0x10165f64 */
        l_0x100e_955a:
            ii(0x100e_955a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_955d, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x100e_9564, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9567, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x100e_956d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_9570, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x100e_9575, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9577, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9578, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9579, 1); popd(esi);                              /* pop esi */
            ii(0x100e_957a, 1); popd(edx);                              /* pop edx */
            ii(0x100e_957b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_957c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_957d, 1); retd(); return;                         /* ret */
        }
    }
}
