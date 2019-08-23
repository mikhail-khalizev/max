using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_caea-9f6935a8")]
        public void my_ctor_c2()
        {
            ii(0x1008_caea, 5); push(0x38);                             /* push 0x38 */
            ii(0x1008_caef, 5); call(Definitions.sys_check_available_stack_size, 0xd_925e); /* call 0x10165d52 */
            ii(0x1008_caf4, 1); push(ecx);                              /* push ecx */
            ii(0x1008_caf5, 1); push(esi);                              /* push esi */
            ii(0x1008_caf6, 1); push(edi);                              /* push edi */
            ii(0x1008_caf7, 1); push(ebp);                              /* push ebp */
            ii(0x1008_caf8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_cafa, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1008_cb00, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb03, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1008_cb06, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1008_cb09, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1008_cb0c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_cb0f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb12, 5); call(0x1008_c86c, -0x2ab);              /* call 0x1008c86c */
            ii(0x1008_cb17, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb1a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_cb1d, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_cb20, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb23, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_cb26, 5); call(Definitions.my_ctor_0x101b_38f8, -0x1_643b); /* call 0x100766f0 */
            ii(0x1008_cb2b, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x1008_cb2e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb31, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_cb34, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_cb37, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb3a, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_cb3d, 5); call(Definitions.my_ctor_0x101b_3b58, -0x1a9e); /* call 0x1008b0a4 */
            ii(0x1008_cb42, 3); sub(eax, 0x1d);                         /* sub eax, 0x1d */
            ii(0x1008_cb45, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb48, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_cb4b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_cb4e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb51, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1008_cb54, 5); call(Definitions.my_ctor_0x101b_4184, -0x1_6069); /* call 0x10076af0 */
            ii(0x1008_cb59, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x1008_cb5c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb5f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb62, 3); add(eax, 0x26);                         /* add eax, 0x26 */
            ii(0x1008_cb65, 5); call(0x1009_c930, 0xfdc6);              /* call 0x1009c930 */
            ii(0x1008_cb6a, 3); sub(eax, 0x26);                         /* sub eax, 0x26 */
            ii(0x1008_cb6d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb70, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_cb73, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_cb76, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb79, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_cb7c, 5); call(0x1009_ca70, 0xfeef);              /* call 0x1009ca70 */
            ii(0x1008_cb81, 3); sub(eax, 0x2b);                         /* sub eax, 0x2b */
            ii(0x1008_cb84, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_cb87, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_cb8a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_cb8d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cb90, 7); mov(memd[ds, eax + 0x2], 0x101b_467c);  /* mov dword [eax+0x2], 0x101b467c */
            ii(0x1008_cb97, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_cb9a, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1008_cb9e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cba1, 4); mov(memw[ds, eax + 0x21], dx);          /* mov [eax+0x21], dx */
            ii(0x1008_cba5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_cba8, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1008_cbac, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cbaf, 4); mov(memw[ds, eax + 0x23], dx);          /* mov [eax+0x23], dx */
            ii(0x1008_cbb3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_cbb6, 4); cmp(memb[ds, eax + 0x3e], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1008_cbba, 2); if(jnz(0x1008_cbc5, 0x9)) goto l_0x1008_cbc5; /* jnz 0x1008cbc5 */
            ii(0x1008_cbbc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cbbf, 4); mov(memb[ds, eax + 0x25], 0xa);         /* mov byte [eax+0x25], 0xa */
            ii(0x1008_cbc3, 2); jmp(0x1008_cbcc, 0x7); goto l_0x1008_cbcc; /* jmp 0x1008cbcc */
        l_0x1008_cbc5:
            ii(0x1008_cbc5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cbc8, 4); mov(memb[ds, eax + 0x25], 0x9);         /* mov byte [eax+0x25], 0x9 */
        l_0x1008_cbcc:
            ii(0x1008_cbcc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cbcf, 4); mov(memb[ds, eax + 0x2a], 0);           /* mov byte [eax+0x2a], 0x0 */
            ii(0x1008_cbd3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_cbd6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cbd9, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_cbdc, 5); call(0x1008_afe4, -0x1bfd);             /* call 0x1008afe4 */
            ii(0x1008_cbe1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_cbe4, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_cbe7, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_cbea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_cbec, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_cbed, 1); pop(edi);                               /* pop edi */
            ii(0x1008_cbee, 1); pop(esi);                               /* pop esi */
            ii(0x1008_cbef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_cbf0, 1); ret();                                  /* ret */
        }
    }
}
