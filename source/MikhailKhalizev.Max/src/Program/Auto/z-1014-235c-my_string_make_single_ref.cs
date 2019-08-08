using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ed6d0b2-ace8-417c-bdd3-06704c2e405e")]
        public void my_string_make_single_ref()
        {
            ii(0x1014_235c, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1014_2361, 5); calld(Definitions.sys_check_available_stack_size, 0x2_39ec); /* call 0x10165d52 */
            ii(0x1014_2366, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_2367, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_2368, 1); pushd(edx);                             /* push edx */
            ii(0x1014_2369, 1); pushd(esi);                             /* push esi */
            ii(0x1014_236a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_236b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_236c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_236e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_2374, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_2377, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_237a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_237c, 5); calld(Definitions.my_strobj_is_single_ref, 0x19b); /* call 0x1014251c */
            ii(0x1014_2381, 2); test(al, al);                           /* test al, al */
            ii(0x1014_2383, 2); if(jnzd(0x1014_23ce, 0x49)) goto l_0x1014_23ce; /* jnz 0x101423ce */
            ii(0x1014_2385, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_2388, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_238a, 5); calld(Definitions.my_string_release, 0x8d); /* call 0x1014241c */
            ii(0x1014_238f, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1014_2394, 5); calld(Definitions.sys_new, 0x2_3a67);   /* call 0x10165e00 */
            ii(0x1014_2399, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_239c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_239f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_23a2, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_23a6, 2); if(jzd(0x1014_23c0, 0x18)) goto l_0x1014_23c0; /* jz 0x101423c0 */
            ii(0x1014_23a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_23ab, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_23ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_23b0, 5); calld(Definitions.my_strobj_ctor_strobj, -0xb9f); /* call 0x10141816 */
            ii(0x1014_23b5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_23b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_23bb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_23be, 2); jmpd(0x1014_23c6, 0x6); goto l_0x1014_23c6; /* jmp 0x101423c6 */
        l_0x1014_23c0:
            ii(0x1014_23c0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_23c3, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1014_23c6:
            ii(0x1014_23c6, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_23c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_23cc, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
        l_0x1014_23ce:
            ii(0x1014_23ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_23d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_23d1, 1); popd(edi);                              /* pop edi */
            ii(0x1014_23d2, 1); popd(esi);                              /* pop esi */
            ii(0x1014_23d3, 1); popd(edx);                              /* pop edx */
            ii(0x1014_23d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_23d5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_23d6, 1); retd(); return;                         /* ret */
        }
    }
}
