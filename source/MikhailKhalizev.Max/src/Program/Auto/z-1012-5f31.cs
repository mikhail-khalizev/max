using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5f31-f44a7069")]
        public void Method_1012_5f31()
        {
            ii(0x1012_5f31, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_5f36, 5); calld(Definitions.sys_check_available_stack_size, 0x3_fe17); /* call 0x10165d52 */
            ii(0x1012_5f3b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_5f3c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_5f3d, 1); pushd(esi);                             /* push esi */
            ii(0x1012_5f3e, 1); pushd(edi);                             /* push edi */
            ii(0x1012_5f3f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5f40, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5f42, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_5f48, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_5f4b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_5f4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_5f51, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_5f54, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_5f57, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5f5a, 5); calld(0x1012_5e4e, -0x111);             /* call 0x10125e4e */
            ii(0x1012_5f5f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5f62, 4); mov(dx, memw_a32[ds, eax + 0x41]);      /* mov dx, [eax+0x41] */
            ii(0x1012_5f66, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5f69, 4); mov(memw_a32[ds, eax + 0x7], dx);       /* mov [eax+0x7], dx */
            ii(0x1012_5f6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5f70, 4); mov(dx, memw_a32[ds, eax + 0x43]);      /* mov dx, [eax+0x43] */
            ii(0x1012_5f74, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5f77, 4); mov(memw_a32[ds, eax + 0x9], dx);       /* mov [eax+0x9], dx */
            ii(0x1012_5f7b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5f7e, 5); calld(0x1007_60e4, -0xa_fe9f);          /* call 0x100760e4 */
            ii(0x1012_5f83, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_5f85, 2); if(jnzd(0x1012_5f92, 0xb)) goto l_0x1012_5f92; /* jnz 0x10125f92 */
            ii(0x1012_5f87, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5f8a, 6); mov(memw_a32[ds, eax + 0xb], 0);        /* mov word [eax+0xb], 0x0 */
            ii(0x1012_5f90, 2); jmpd(0x1012_5fa8, 0x16); goto l_0x1012_5fa8; /* jmp 0x10125fa8 */
        l_0x1012_5f92:
            ii(0x1012_5f92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5f95, 5); calld(0x1007_60e4, -0xa_feb6);          /* call 0x100760e4 */
            ii(0x1012_5f9a, 5); calld(0x1007_6154, -0xa_fe4b);          /* call 0x10076154 */
            ii(0x1012_5f9f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_5fa1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5fa4, 4); mov(memw_a32[ds, eax + 0xb], dx);       /* mov [eax+0xb], dx */
        l_0x1012_5fa8:
            ii(0x1012_5fa8, 7); mov(memd_a32[ss, ebp - 0xc], 0xd);      /* mov dword [ebp-0xc], 0xd */
            ii(0x1012_5faf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_5fb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5fb4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_5fb5, 1); popd(edi);                              /* pop edi */
            ii(0x1012_5fb6, 1); popd(esi);                              /* pop esi */
            ii(0x1012_5fb7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_5fb8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_5fb9, 1); retd();                                 /* ret */
        }
    }
}
