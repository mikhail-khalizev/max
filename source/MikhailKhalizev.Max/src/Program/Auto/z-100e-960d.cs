using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ca197a4-d075-4317-bf2b-c1b6f245d644")]
        public void Method_100e_960d()
        {
            ii(0x100e_960d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_9612, 5); calld(Definitions.sys_check_available_stack_size, 0x7_c73b); /* call 0x10165d52 */
            ii(0x100e_9617, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_9618, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_9619, 1); pushd(edx);                             /* push edx */
            ii(0x100e_961a, 1); pushd(esi);                             /* push esi */
            ii(0x100e_961b, 1); pushd(edi);                             /* push edi */
            ii(0x100e_961c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_961d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_961f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_9625, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_9628, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_962f, 2); jmpd(0x100e_9637, 0x6); goto l_0x100e_9637; /* jmp 0x100e9637 */
        l_0x100e_9631:
            ii(0x100e_9631, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_9634, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100e_9637:
            ii(0x100e_9637, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_963a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_963d, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100e_9641, 2); if(jged(0x100e_965d, 0x1a)) goto l_0x100e_965d; /* jge 0x100e965d */
            ii(0x100e_9643, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_9647, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_964a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_964c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_964f, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100e_9652, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_9654, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_9656, 5); calld(/* sys */ 0x1016_9870, 0x8_0215); /* call 0x10169870 */
            ii(0x100e_965b, 2); jmpd(0x100e_9631, -0x2c); goto l_0x100e_9631; /* jmp 0x100e9631 */
        l_0x100e_965d:
            ii(0x100e_965d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_965f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_9660, 1); popd(edi);                              /* pop edi */
            ii(0x100e_9661, 1); popd(esi);                              /* pop esi */
            ii(0x100e_9662, 1); popd(edx);                              /* pop edx */
            ii(0x100e_9663, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_9664, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_9665, 1); retd(); return;                         /* ret */
        }
    }
}
