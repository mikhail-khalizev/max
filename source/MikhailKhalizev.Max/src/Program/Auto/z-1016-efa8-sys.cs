using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_efa8-71a3328a")]
        public void /* sys */ Method_1016_efa8()
        {
            ii(0x1016_efa8, 1); push(ebx);                              /* push ebx */
            ii(0x1016_efa9, 1); push(ecx);                              /* push ecx */
            ii(0x1016_efaa, 1); push(edx);                              /* push edx */
            ii(0x1016_efab, 1); push(esi);                              /* push esi */
            ii(0x1016_efac, 1); push(edi);                              /* push edi */
            ii(0x1016_efad, 1); push(ebp);                              /* push ebp */
            ii(0x1016_efae, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_efb0, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1016_efb5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_efb7, 6); if(jz(0x1016_f13f, 0x182)) goto l_0x1016_f13f; /* jz 0x1016f13f */
            ii(0x1016_efbd, 4); test(memb[ds, eax + 4], 4);             /* test byte [eax+0x4], 0x4 */
            ii(0x1016_efc1, 2); if(jz(0x1016_efd2, 0xf)) goto l_0x1016_efd2; /* jz 0x1016efd2 */
            ii(0x1016_efc3, 3); mov(eax, memd[ds, ecx + 0xc]);          /* mov eax, [ecx+0xc] */
            ii(0x1016_efc6, 5); call(/* sys */ 0x1017_1f05, 0x2f3a);    /* call 0x10171f05 */
            ii(0x1016_efcb, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_efcd, 5); jmp(0x1016_f13f, 0x16d); goto l_0x1016_f13f; /* jmp 0x1016f13f */
        l_0x1016_efd2:
            ii(0x1016_efd2, 3); mov(eax, memd[ds, ecx + 4]);            /* mov eax, [ecx+0x4] */
            ii(0x1016_efd5, 5); and(eax, 0xf0);                         /* and eax, 0xf0 */
            ii(0x1016_efda, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1016_efdd, 2); if(jb(0x1016_efeb, 0xc)) goto l_0x1016_efeb; /* jb 0x1016efeb */
            ii(0x1016_efdf, 2); if(jbe(0x1016_f054, 0x73)) goto l_0x1016_f054; /* jbe 0x1016f054 */
            ii(0x1016_efe1, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1016_efe4, 2); if(jz(0x1016_eff5, 0xf)) goto l_0x1016_eff5; /* jz 0x1016eff5 */
            ii(0x1016_efe6, 5); jmp(0x1016_f13f, 0x154); goto l_0x1016_f13f; /* jmp 0x1016f13f */
        l_0x1016_efeb:
            ii(0x1016_efeb, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1016_efee, 2); if(jz(0x1016_effc, 0xc)) goto l_0x1016_effc; /* jz 0x1016effc */
            ii(0x1016_eff0, 5); jmp(0x1016_f13f, 0x14a); goto l_0x1016_f13f; /* jmp 0x1016f13f */
        l_0x1016_eff5:
            ii(0x1016_eff5, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_eff7, 5); call(/* sys */ 0x1017_11bc, 0x21c0);    /* call 0x101711bc */
        l_0x1016_effc:
            ii(0x1016_effc, 4); cmp(memd[ds, ecx + 0x10], 0);           /* cmp dword [ecx+0x10], 0x0 */
            ii(0x1016_f000, 6); if(jbe(0x1016_f13f, 0x139)) goto l_0x1016_f13f; /* jbe 0x1016f13f */
            ii(0x1016_f006, 3); mov(eax, memd[ds, ecx + 0x20]);         /* mov eax, [ecx+0x20] */
            ii(0x1016_f009, 3); mov(edx, memd[ds, ecx + 0x10]);         /* mov edx, [ecx+0x10] */
            ii(0x1016_f00c, 1); inc(eax);                               /* inc eax */
            ii(0x1016_f00d, 1); dec(edx);                               /* dec edx */
            ii(0x1016_f00e, 4); movzx(esi, memb[ds, eax - 1]);          /* movzx esi, byte [eax-0x1] */
            ii(0x1016_f012, 3); mov(memd[ds, ecx + 0x20], eax);         /* mov [ecx+0x20], eax */
            ii(0x1016_f015, 3); mov(memd[ds, ecx + 0x10], edx);         /* mov [ecx+0x10], edx */
            ii(0x1016_f018, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_f01a, 6); if(jbe(0x1016_f13f, 0x11f)) goto l_0x1016_f13f; /* jbe 0x1016f13f */
            ii(0x1016_f020, 4); test(memb[ds, ecx + 4], 2);             /* test byte [ecx+0x4], 0x2 */
            ii(0x1016_f024, 6); if(jz(0x1016_f13f, 0x115)) goto l_0x1016_f13f; /* jz 0x1016f13f */
            ii(0x1016_f02a, 3); cmp(esi, 0xd);                          /* cmp esi, 0xd */
            ii(0x1016_f02d, 6); if(jnz(0x1016_f13f, 0x10c)) goto l_0x1016_f13f; /* jnz 0x1016f13f */
            ii(0x1016_f033, 3); mov(eax, memd[ds, ecx + 0x20]);         /* mov eax, [ecx+0x20] */
            ii(0x1016_f036, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1016_f038, 3); cmp(dl, 0xa);                           /* cmp dl, 0xa */
            ii(0x1016_f03b, 6); if(jnz(0x1016_f13f, 0xfe)) goto l_0x1016_f13f; /* jnz 0x1016f13f */
            ii(0x1016_f041, 3); mov(edi, memd[ds, ecx + 0x10]);         /* mov edi, [ecx+0x10] */
            ii(0x1016_f044, 1); inc(eax);                               /* inc eax */
            ii(0x1016_f045, 1); dec(edi);                               /* dec edi */
            ii(0x1016_f046, 3); mov(memd[ds, ecx + 0x20], eax);         /* mov [ecx+0x20], eax */
            ii(0x1016_f049, 3); movzx(esi, dl);                         /* movzx esi, dl */
            ii(0x1016_f04c, 3); mov(memd[ds, ecx + 0x10], edi);         /* mov [ecx+0x10], edi */
            ii(0x1016_f04f, 5); jmp(0x1016_f13f, 0xeb); goto l_0x1016_f13f; /* jmp 0x1016f13f */
        l_0x1016_f054:
            ii(0x1016_f054, 4); cmp(memd[ds, ecx + 0x10], 0);           /* cmp dword [ecx+0x10], 0x0 */
            ii(0x1016_f058, 6); if(jbe(0x1016_f13f, 0xe1)) goto l_0x1016_f13f; /* jbe 0x1016f13f */
            ii(0x1016_f05e, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_f060, 3); mov(edx, memd[ds, ecx + 0x18]);         /* mov edx, [ecx+0x18] */
            ii(0x1016_f063, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_f065, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_f068, 5); call(Definitions.sys_fseek, 0x3403);    /* call 0x10172470 */
            ii(0x1016_f06d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_f06f, 6); if(jnz(0x1016_f13f, 0xca)) goto l_0x1016_f13f; /* jnz 0x1016f13f */
            ii(0x1016_f075, 2); mov(esi, memd[ds, ecx]);                /* mov esi, [ecx] */
            ii(0x1016_f077, 3); mov(esi, memd[ds, esi + 4]);            /* mov esi, [esi+0x4] */
            ii(0x1016_f07a, 3); mov(ebx, memd[ds, esi + 4]);            /* mov ebx, [esi+0x4] */
            ii(0x1016_f07d, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_f07f, 2); if(jle(0x1016_f095, 0x14)) goto l_0x1016_f095; /* jle 0x1016f095 */
            ii(0x1016_f081, 4); test(memb[ds, esi + 0xc], 4);           /* test byte [esi+0xc], 0x4 */
            ii(0x1016_f085, 2); if(jnz(0x1016_f095, 0xe)) goto l_0x1016_f095; /* jnz 0x1016f095 */
            ii(0x1016_f087, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1016_f089, 2); mov(dh, memb[ds, eax]);                 /* mov dh, [eax] */
            ii(0x1016_f08b, 3); cmp(dh, 0xd);                           /* cmp dh, 0xd */
            ii(0x1016_f08e, 2); if(jz(0x1016_f095, 5)) goto l_0x1016_f095; /* jz 0x1016f095 */
            ii(0x1016_f090, 3); cmp(dh, 0x1a);                          /* cmp dh, 0x1a */
            ii(0x1016_f093, 2); if(jnz(0x1016_f0a1, 0xc)) goto l_0x1016_f0a1; /* jnz 0x1016f0a1 */
        l_0x1016_f095:
            ii(0x1016_f095, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_f097, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_f09a, 5); call(/* sys */ 0x1017_1f05, 0x2e66);    /* call 0x10171f05 */
            ii(0x1016_f09f, 2); jmp(0x1016_f0b7, 0x16); goto l_0x1016_f0b7; /* jmp 0x1016f0b7 */
        l_0x1016_f0a1:
            ii(0x1016_f0a1, 3); lea(edi, memd[ds, ebx - 1]);            /* lea edi, [ebx-0x1] */
            ii(0x1016_f0a4, 3); mov(memd[ds, esi + 4], edi);            /* mov [esi+0x4], edi */
            ii(0x1016_f0a7, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_f0a9, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_f0ac, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1016_f0ae, 3); lea(esi, memd[ds, edx + 1]);            /* lea esi, [edx+0x1] */
            ii(0x1016_f0b1, 2); mov(memd[ds, eax], esi);                /* mov [eax], esi */
            ii(0x1016_f0b3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f0b5, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
        l_0x1016_f0b7:
            ii(0x1016_f0b7, 3); mov(ebp, memd[ds, ecx + 0x10]);         /* mov ebp, [ecx+0x10] */
            ii(0x1016_f0ba, 1); dec(ebp);                               /* dec ebp */
            ii(0x1016_f0bb, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_f0bd, 3); mov(memd[ds, ecx + 0x10], ebp);         /* mov [ecx+0x10], ebp */
            ii(0x1016_f0c0, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_f0c2, 6); if(jbe(0x1016_f132, 0x6a)) goto l_0x1016_f132; /* jbe 0x1016f132 */
            ii(0x1016_f0c8, 4); test(memb[ds, ecx + 4], 2);             /* test byte [ecx+0x4], 0x2 */
            ii(0x1016_f0cc, 6); if(jz(0x1016_f132, 0x60)) goto l_0x1016_f132; /* jz 0x1016f132 */
            ii(0x1016_f0d2, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1016_f0d5, 2); if(jnz(0x1016_f132, 0x5b)) goto l_0x1016_f132; /* jnz 0x1016f132 */
            ii(0x1016_f0d7, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_f0d9, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_f0dc, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x1016_f0e0, 2); if(jle(0x1016_f0f6, 0x14)) goto l_0x1016_f0f6; /* jle 0x1016f0f6 */
            ii(0x1016_f0e2, 4); test(memb[ds, eax + 0xc], 4);           /* test byte [eax+0xc], 0x4 */
            ii(0x1016_f0e6, 2); if(jnz(0x1016_f0f6, 0xe)) goto l_0x1016_f0f6; /* jnz 0x1016f0f6 */
            ii(0x1016_f0e8, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1016_f0ea, 2); mov(bl, memb[ds, edx]);                 /* mov bl, [edx] */
            ii(0x1016_f0ec, 3); cmp(bl, 0xd);                           /* cmp bl, 0xd */
            ii(0x1016_f0ef, 2); if(jz(0x1016_f0f6, 5)) goto l_0x1016_f0f6; /* jz 0x1016f0f6 */
            ii(0x1016_f0f1, 3); cmp(bl, 0x1a);                          /* cmp bl, 0x1a */
            ii(0x1016_f0f4, 2); if(jnz(0x1016_f102, 0xc)) goto l_0x1016_f102; /* jnz 0x1016f102 */
        l_0x1016_f0f6:
            ii(0x1016_f0f6, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_f0f8, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_f0fb, 5); call(/* sys */ 0x1017_1f05, 0x2e05);    /* call 0x10171f05 */
            ii(0x1016_f100, 2); jmp(0x1016_f118, 0x16); goto l_0x1016_f118; /* jmp 0x1016f118 */
        l_0x1016_f102:
            ii(0x1016_f102, 3); dec(memd[ds, eax + 4]);                 /* dec dword [eax+0x4] */
            ii(0x1016_f105, 2); mov(edx, memd[ds, ecx]);                /* mov edx, [ecx] */
            ii(0x1016_f107, 3); mov(edx, memd[ds, edx + 4]);            /* mov edx, [edx+0x4] */
            ii(0x1016_f10a, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1016_f10c, 3); lea(ebx, memd[ds, eax + 1]);            /* lea ebx, [eax+0x1] */
            ii(0x1016_f10f, 2); mov(memd[ds, edx], ebx);                /* mov [edx], ebx */
            ii(0x1016_f111, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1016_f113, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1016_f118:
            ii(0x1016_f118, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1016_f11b, 2); if(jnz(0x1016_f128, 0xb)) goto l_0x1016_f128; /* jnz 0x1016f128 */
            ii(0x1016_f11d, 3); mov(ebp, memd[ds, ecx + 0x10]);         /* mov ebp, [ecx+0x10] */
            ii(0x1016_f120, 1); dec(ebp);                               /* dec ebp */
            ii(0x1016_f121, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_f123, 3); mov(memd[ds, ecx + 0x10], ebp);         /* mov [ecx+0x10], ebp */
            ii(0x1016_f126, 2); jmp(0x1016_f132, 0xa); goto l_0x1016_f132; /* jmp 0x1016f132 */
        l_0x1016_f128:
            ii(0x1016_f128, 2); mov(edx, memd[ds, ecx]);                /* mov edx, [ecx] */
            ii(0x1016_f12a, 3); mov(edx, memd[ds, edx + 4]);            /* mov edx, [edx+0x4] */
            ii(0x1016_f12d, 5); call(/* sys */ 0x1018_b4e9, 0x1_c3b7);  /* call 0x1018b4e9 */
        l_0x1016_f132:
            ii(0x1016_f132, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1016_f134, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_f137, 5); call(Definitions.sys_ftell, 0x360b);    /* call 0x10172747 */
            ii(0x1016_f13c, 3); mov(memd[ds, ecx + 0x18], eax);         /* mov [ecx+0x18], eax */
        l_0x1016_f13f:
            ii(0x1016_f13f, 7); cmp(memd[ds, 0x101b_e1dc], 0);          /* cmp dword [0x101be1dc], 0x0 */
            ii(0x1016_f146, 2); if(jz(0x1016_f16b, 0x23)) goto l_0x1016_f16b; /* jz 0x1016f16b */
            ii(0x1016_f148, 5); mov(eax, memd[ds, 0x101b_e1d4]);        /* mov eax, [0x101be1d4] */
            ii(0x1016_f14d, 1); inc(eax);                               /* inc eax */
            ii(0x1016_f14e, 6); mov(edx, memd[ds, 0x101b_e1d8]);        /* mov edx, [0x101be1d8] */
            ii(0x1016_f154, 5); mov(memd[ds, 0x101b_e1d4], eax);        /* mov [0x101be1d4], eax */
            ii(0x1016_f159, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_f15b, 2); if(jb(0x1016_f16b, 0xe)) goto l_0x1016_f16b; /* jb 0x1016f16b */
            ii(0x1016_f15d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_f15f, 6); mov(memd[ds, 0x101b_e1d4], ebx);        /* mov [0x101be1d4], ebx */
            ii(0x1016_f165, 6); call_abs(memd[ds, 0x101b_e1dc]);        /* call dword [0x101be1dc] */
        l_0x1016_f16b:
            ii(0x1016_f16b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_f16d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_f16e, 1); pop(edi);                               /* pop edi */
            ii(0x1016_f16f, 1); pop(esi);                               /* pop esi */
            ii(0x1016_f170, 1); pop(edx);                               /* pop edx */
            ii(0x1016_f171, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_f172, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_f173, 1); ret();                                  /* ret */
        }
    }
}
