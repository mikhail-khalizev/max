using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2723270b-1b0b-4cbd-98a2-aa38e5da1a70")]
        public void Method_100e_4cfc()
        {
            ii(0x100e_4cfc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_4d01, 5); calld(Definitions.sys_check_available_stack_size, 0x8104c); /* call 0x10165d52 */
            ii(0x100e_4d06, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4d07, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4d08, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4d09, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4d0b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_4d11, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_4d14, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_4d17, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_4d1a, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100e_4d1d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4d20, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100e_4d24, 2); if(jld(0x100e_4d2f, 0x9)) goto l_0x100e_4d2f; /* jl 0x100e4d2f */
            ii(0x100e_4d26, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4d29, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_4d2d, 2); if(jled(0x100e_4d31, 0x2)) goto l_0x100e_4d31; /* jle 0x100e4d31 */
        l_0x100e_4d2f:
            ii(0x100e_4d2f, 2); jmpd(0x100e_4d3a, 0x9); goto l_0x100e_4d3a; /* jmp 0x100e4d3a */
        l_0x100e_4d31:
            ii(0x100e_4d31, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100e_4d38, 2); jmpd(0x100e_4d70, 0x36); goto l_0x100e_4d70; /* jmp 0x100e4d70 */
        l_0x100e_4d3a:
            ii(0x100e_4d3a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4d3d, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100e_4d41, 2); if(jgd(0x100e_4d4c, 0x9)) goto l_0x100e_4d4c; /* jg 0x100e4d4c */
            ii(0x100e_4d43, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4d46, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100e_4d4a, 2); if(jged(0x100e_4d4e, 0x2)) goto l_0x100e_4d4e; /* jge 0x100e4d4e */
        l_0x100e_4d4c:
            ii(0x100e_4d4c, 2); jmpd(0x100e_4d57, 0x9); goto l_0x100e_4d57; /* jmp 0x100e4d57 */
        l_0x100e_4d4e:
            ii(0x100e_4d4e, 7); mov(memd_a32[ss, ebp - 0x14], 0x3);     /* mov dword [ebp-0x14], 0x3 */
            ii(0x100e_4d55, 2); jmpd(0x100e_4d70, 0x19); goto l_0x100e_4d70; /* jmp 0x100e4d70 */
        l_0x100e_4d57:
            ii(0x100e_4d57, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4d5a, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x100e_4d5e, 2); if(jged(0x100e_4d69, 0x9)) goto l_0x100e_4d69; /* jge 0x100e4d69 */
            ii(0x100e_4d60, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x100e_4d67, 2); jmpd(0x100e_4d70, 0x7); goto l_0x100e_4d70; /* jmp 0x100e4d70 */
        l_0x100e_4d69:
            ii(0x100e_4d69, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
        l_0x100e_4d70:
            ii(0x100e_4d70, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_4d73, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4d75, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4d76, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4d77, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4d78, 1); retd(); return;                         /* ret */
        }
    }
}
