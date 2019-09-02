using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_85f1-8cec7798")]
        public void Method_1011_85f1()
        {
            ii(0x1011_85f1, 5); push(0x30);                             /* push 0x30 */
            ii(0x1011_85f6, 5); call(Definitions.sys_check_available_stack_size, 0x4_d757); /* call 0x10165d52 */
            ii(0x1011_85fb, 1); push(ebx);                              /* push ebx */
            ii(0x1011_85fc, 1); push(ecx);                              /* push ecx */
            ii(0x1011_85fd, 1); push(edx);                              /* push edx */
            ii(0x1011_85fe, 1); push(esi);                              /* push esi */
            ii(0x1011_85ff, 1); push(edi);                              /* push edi */
            ii(0x1011_8600, 1); push(ebp);                              /* push ebp */
            ii(0x1011_8601, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8603, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_8609, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_860c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_860f, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_8612, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_8615, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8618, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1011_861b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_861e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8621, 5); call(0x1007_510b, -0xa_351b);           /* call 0x1007510b */
            ii(0x1011_8626, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_8629, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_862d, 2); if(jnz(0x1011_8638, 9)) goto l_0x1011_8638; /* jnz 0x10118638 */
            ii(0x1011_862f, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1011_8633, 5); jmp(0x1011_874c, 0x114); goto l_0x1011_874c; /* jmp 0x1011874c */
        l_0x1011_8638:
            ii(0x1011_8638, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_863b, 5); cmp(memw[ds, eax + 8], 0x16);           /* cmp word [eax+0x8], 0x16 */
            ii(0x1011_8640, 2); if(jnz(0x1011_8668, 0x26)) goto l_0x1011_8668; /* jnz 0x10118668 */
            ii(0x1011_8642, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8645, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1011_8648, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_864a, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_864d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8650, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x1011_8653, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8656, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8659, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1011_865c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_865f, 5); call(0x1007_3aa6, -0xa_4bbe);           /* call 0x10073aa6 */
            ii(0x1011_8664, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_8666, 2); if(jz(0x1011_866a, 2)) goto l_0x1011_866a; /* jz 0x1011866a */
        l_0x1011_8668:
            ii(0x1011_8668, 2); jmp(0x1011_868b, 0x21); goto l_0x1011_868b; /* jmp 0x1011868b */
        l_0x1011_866a:
            ii(0x1011_866a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_866c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_866f, 5); call(0x1008_a998, -0x8_dcdc);           /* call 0x1008a998 */
            ii(0x1011_8674, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8677, 4); mov(memb[ds, eax + 0x3d], 0xd);         /* mov byte [eax+0x3d], 0xd */
            ii(0x1011_867b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_867e, 4); mov(memb[ds, eax + 0x3e], 0);           /* mov byte [eax+0x3e], 0x0 */
            ii(0x1011_8682, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1011_8686, 5); jmp(0x1011_874c, 0xc1); goto l_0x1011_874c; /* jmp 0x1011874c */
        l_0x1011_868b:
            ii(0x1011_868b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_868e, 5); cmp(memw[ds, eax + 8], 0xa);            /* cmp word [eax+0x8], 0xa */
            ii(0x1011_8693, 2); if(jnz(0x1011_869e, 9)) goto l_0x1011_869e; /* jnz 0x1011869e */
            ii(0x1011_8695, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8698, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1011_869c, 2); if(jz(0x1011_86a3, 5)) goto l_0x1011_86a3; /* jz 0x101186a3 */
        l_0x1011_869e:
            ii(0x1011_869e, 5); jmp(0x1011_8748, 0xa5); goto l_0x1011_8748; /* jmp 0x10118748 */
        l_0x1011_86a3:
            ii(0x1011_86a3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_86a6, 5); call(0x1007_623c, -0xa_246f);           /* call 0x1007623c */
            ii(0x1011_86ab, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_86ae, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_86b1, 5); call(0x1007_34d7, -0xa_51df);           /* call 0x100734d7 */
            ii(0x1011_86b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_86b8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_86bb, 4); cmp(dx, memw[ds, eax + 0x19]);          /* cmp dx, [eax+0x19] */
            ii(0x1011_86bf, 2); if(jz(0x1011_86f5, 0x34)) goto l_0x1011_86f5; /* jz 0x101186f5 */
            ii(0x1011_86c1, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1011_86c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_86c7, 5); call(0x1008_a998, -0x8_dd34);           /* call 0x1008a998 */
            ii(0x1011_86cc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_86cf, 4); mov(memb[ds, eax + 0x3d], 0xd);         /* mov byte [eax+0x3d], 0xd */
            ii(0x1011_86d3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_86d6, 4); mov(memb[ds, eax + 0x3e], 0);           /* mov byte [eax+0x3e], 0x0 */
            ii(0x1011_86da, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_86df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_86e2, 5); call(0x1007_6d98, -0xa_194f);           /* call 0x10076d98 */
            ii(0x1011_86e7, 2); test(al, al);                           /* test al, al */
            ii(0x1011_86e9, 2); if(jz(0x1011_86f3, 8)) goto l_0x1011_86f3; /* jz 0x101186f3 */
            ii(0x1011_86eb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_86ee, 5); call(0x100f_f637, -0x1_90bc);           /* call 0x100ff637 */
        l_0x1011_86f3:
            ii(0x1011_86f3, 2); jmp(0x1011_8742, 0x4d); goto l_0x1011_8742; /* jmp 0x10118742 */
        l_0x1011_86f5:
            ii(0x1011_86f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_86f8, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1011_86fc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_86ff, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
            ii(0x1011_8703, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_8708, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_870b, 5); call(0x1007_6d98, -0xa_1978);           /* call 0x10076d98 */
            ii(0x1011_8710, 2); test(al, al);                           /* test al, al */
            ii(0x1011_8712, 2); if(jz(0x1011_8742, 0x2e)) goto l_0x1011_8742; /* jz 0x10118742 */
            ii(0x1011_8714, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_8717, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_871a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_871d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_8720, 3); mov(edx, memd[ds, edx + 0x18]);         /* mov edx, [edx+0x18] */
            ii(0x1011_8723, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8726, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_8729, 5); call(0x1007_6aac, -0xa_1c82);           /* call 0x10076aac */
            ii(0x1011_872e, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1011_8730, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1011_8733, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1011_8738, 5); mov(eax, StringDefinitions.UnableToMoveUnitIntoHoldingArea); /* mov eax, 0x101a7c63 */
            ii(0x1011_873d, 5); call(0x1011_5b60, -0x2be2);             /* call 0x10115b60 */
        l_0x1011_8742:
            ii(0x1011_8742, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1011_8746, 2); jmp(0x1011_874c, 4); goto l_0x1011_874c; /* jmp 0x1011874c */
        l_0x1011_8748:
            ii(0x1011_8748, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x1011_874c:
            ii(0x1011_874c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1011_874f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8751, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_8752, 1); pop(edi);                               /* pop edi */
            ii(0x1011_8753, 1); pop(esi);                               /* pop esi */
            ii(0x1011_8754, 1); pop(edx);                               /* pop edx */
            ii(0x1011_8755, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_8756, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_8757, 1); ret();                                  /* ret */
        }
    }
}
