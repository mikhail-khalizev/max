using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8f63-66afab6")]
        public void Method_100b_8f63()
        {
            ii(0x100b_8f63, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_8f68, 5); calld(Definitions.sys_check_available_stack_size, 0xa_cde5); /* call 0x10165d52 */
            ii(0x100b_8f6d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_8f6e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8f6f, 1); pushd(edx);                             /* push edx */
            ii(0x100b_8f70, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8f71, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8f72, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8f73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8f75, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_8f7b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_8f7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8f81, 4); cmp(memb_a32[ds, eax + 0x14], 0);       /* cmp byte [eax+0x14], 0x0 */
            ii(0x100b_8f85, 2); if(jnzd(0x100b_8fa4, 0x1d)) goto l_0x100b_8fa4; /* jnz 0x100b8fa4 */
            ii(0x100b_8f87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8f8a, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100b_8f8d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_8f90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8f93, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8f96, 5); calld(0x1007_6574, -0x4_2a27);          /* call 0x10076574 */
            ii(0x100b_8f9b, 5); calld(0x1007_6074, -0x4_2f2c);          /* call 0x10076074 */
            ii(0x100b_8fa0, 2); test(al, al);                           /* test al, al */
            ii(0x100b_8fa2, 2); if(jzd(0x100b_8ff1, 0x4d)) goto l_0x100b_8ff1; /* jz 0x100b8ff1 */
        l_0x100b_8fa4:
            ii(0x100b_8fa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fa7, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8faa, 5); calld(0x1007_6574, -0x4_2a3b);          /* call 0x10076574 */
            ii(0x100b_8faf, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x100b_8fb3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fb6, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x100b_8fba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fbd, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8fc0, 5); calld(0x1007_6574, -0x4_2a51);          /* call 0x10076574 */
            ii(0x100b_8fc5, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x100b_8fc9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fcc, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
            ii(0x100b_8fd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fd3, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100b_8fd6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_8fd9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fdc, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100b_8fdf, 5); calld(0x1007_6574, -0x4_2a70);          /* call 0x10076574 */
            ii(0x100b_8fe4, 5); calld(0x1007_6074, -0x4_2f75);          /* call 0x10076074 */
            ii(0x100b_8fe9, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_8feb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8fee, 3); mov(memb_a32[ds, eax + 0x14], dl);      /* mov [eax+0x14], dl */
        l_0x100b_8ff1:
            ii(0x100b_8ff1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8ff3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8ff4, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8ff5, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8ff6, 1); popd(edx);                              /* pop edx */
            ii(0x100b_8ff7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8ff8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8ff9, 1); retd();                                 /* ret */
        }
    }
}
