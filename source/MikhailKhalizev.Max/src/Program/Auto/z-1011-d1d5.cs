using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e4c0d954-bbe8-49b3-b0b9-9d3aa12f2ab5")]
        public void Method_1011_d1d5()
        {
            ii(0x1011_d1d5, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_d1da, 5); calld(Definitions.sys_check_available_stack_size, 0x4_8b73); /* call 0x10165d52 */
            ii(0x1011_d1df, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_d1e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_d1e1, 1); pushd(edx);                             /* push edx */
            ii(0x1011_d1e2, 1); pushd(esi);                             /* push esi */
            ii(0x1011_d1e3, 1); pushd(edi);                             /* push edi */
            ii(0x1011_d1e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_d1e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d1e7, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_d1ed, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_d1f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d1f3, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d1f6, 5); calld(0x1007_6574, -0xa_6c87);          /* call 0x10076574 */
            ii(0x1011_d1fb, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1011_d1fe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_d203, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_d205, 2); if(jled(0x1011_d23e, 0x37)) goto l_0x1011_d23e; /* jle 0x1011d23e */
            ii(0x1011_d207, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d20a, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d20d, 5); calld(0x1007_6574, -0xa_6c9e);          /* call 0x10076574 */
            ii(0x1011_d212, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1011_d216, 2); if(jzd(0x1011_d229, 0x11)) goto l_0x1011_d229; /* jz 0x1011d229 */
            ii(0x1011_d218, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d21b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d21e, 5); calld(0x1007_6574, -0xa_6caf);          /* call 0x10076574 */
            ii(0x1011_d223, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1b);    /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1011_d227, 2); if(jnzd(0x1011_d22b, 0x2)) goto l_0x1011_d22b; /* jnz 0x1011d22b */
        l_0x1011_d229:
            ii(0x1011_d229, 2); jmpd(0x1011_d23c, 0x11); goto l_0x1011_d23c; /* jmp 0x1011d23c */
        l_0x1011_d22b:
            ii(0x1011_d22b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d22e, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d231, 5); calld(0x1007_6574, -0xa_6cc2);          /* call 0x10076574 */
            ii(0x1011_d236, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1e);    /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_d23a, 2); if(jnzd(0x1011_d23e, 0x2)) goto l_0x1011_d23e; /* jnz 0x1011d23e */
        l_0x1011_d23c:
            ii(0x1011_d23c, 2); jmpd(0x1011_d240, 0x2); goto l_0x1011_d240; /* jmp 0x1011d240 */
        l_0x1011_d23e:
            ii(0x1011_d23e, 2); jmpd(0x1011_d251, 0x11); goto l_0x1011_d251; /* jmp 0x1011d251 */
        l_0x1011_d240:
            ii(0x1011_d240, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d243, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d246, 5); calld(0x1007_6574, -0xa_6cd7);          /* call 0x10076574 */
            ii(0x1011_d24b, 4); cmp(memb_a32[ds, eax + 0x3e], 0x2a);    /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1011_d24f, 2); if(jzd(0x1011_d253, 0x2)) goto l_0x1011_d253; /* jz 0x1011d253 */
        l_0x1011_d251:
            ii(0x1011_d251, 2); jmpd(0x1011_d279, 0x26); goto l_0x1011_d279; /* jmp 0x1011d279 */
        l_0x1011_d253:
            ii(0x1011_d253, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1011_d258, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d25b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d25e, 5); calld(0x1007_6574, -0xa_6cef);          /* call 0x10076574 */
            ii(0x1011_d263, 3); mov(edx, memd_a32[ds, eax + 0x3a]);     /* mov edx, [eax+0x3a] */
            ii(0x1011_d266, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1011_d269, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d26c, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d26f, 5); calld(0x1007_65d0, -0xa_6ca4);          /* call 0x100765d0 */
            ii(0x1011_d274, 5); calld(0x1016_3053, 0x4_5dda);           /* call 0x10163053 */
        l_0x1011_d279:
            ii(0x1011_d279, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_d27c, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1011_d27f, 5); calld(0x1007_65d0, -0xa_6cb4);          /* call 0x100765d0 */
            ii(0x1011_d284, 5); calld(0x1007_5a79, -0xa_7810);          /* call 0x10075a79 */
            ii(0x1011_d289, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d28b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d28c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d28d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d28e, 1); popd(edx);                              /* pop edx */
            ii(0x1011_d28f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_d290, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_d291, 1); retd(); return;                         /* ret */
        }
    }
}
