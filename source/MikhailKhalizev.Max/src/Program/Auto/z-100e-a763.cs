using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("432886e2-831b-4340-bfbe-ee5ac33c21b7")]
        public void Method_100e_a763()
        {
            ii(0x100e_a763, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_a768, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b5e5); /* call 0x10165d52 */
            ii(0x100e_a76d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a76e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a76f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a770, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a772, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100e_a778, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a77b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_a77e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_a781, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x100e_a784, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_a78b, 2); jmpd(0x100e_a793, 0x6); goto l_0x100e_a793; /* jmp 0x100ea793 */
        l_0x100e_a78d:
            ii(0x100e_a78d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_a790, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100e_a793:
            ii(0x100e_a793, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_a796, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100e_a79a, 2); if(jged(0x100e_a7df, 0x43)) goto l_0x100e_a7df; /* jge 0x100ea7df */
            ii(0x100e_a79c, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100e_a7a3, 2); jmpd(0x100e_a7ab, 0x6); goto l_0x100e_a7ab; /* jmp 0x100ea7ab */
        l_0x100e_a7a5:
            ii(0x100e_a7a5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_a7a8, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100e_a7ab:
            ii(0x100e_a7ab, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_a7ae, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_a7b2, 2); if(jged(0x100e_a7d0, 0x1c)) goto l_0x100e_a7d0; /* jge 0x100ea7d0 */
            ii(0x100e_a7b4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a7b7, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_a7b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_a7be, 3); add(eax, memd_a32[ss, ebp + 0x10]);     /* add eax, [ebp+0x10] */
            ii(0x100e_a7c1, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x100e_a7c3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a7c6, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100e_a7c8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_a7cb, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x100e_a7ce, 2); jmpd(0x100e_a7a5, -0x2b); goto l_0x100e_a7a5; /* jmp 0x100ea7a5 */
        l_0x100e_a7d0:
            ii(0x100e_a7d0, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_a7d4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_a7d8, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_a7da, 3); add(memd_a32[ss, ebp - 0x10], edx);     /* add [ebp-0x10], edx */
            ii(0x100e_a7dd, 2); jmpd(0x100e_a78d, -0x52); goto l_0x100e_a78d; /* jmp 0x100ea78d */
        l_0x100e_a7df:
            ii(0x100e_a7df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a7e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a7e2, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a7e3, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a7e4, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
