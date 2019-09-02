using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_0683-48f74830")]
        public void Method_1010_0683()
        {
            ii(0x1010_0683, 5); push(0x34);                             /* push 0x34 */
            ii(0x1010_0688, 5); call(Definitions.sys_check_available_stack_size, 0x6_56c5); /* call 0x10165d52 */
            ii(0x1010_068d, 1); push(ebx);                              /* push ebx */
            ii(0x1010_068e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_068f, 1); push(edx);                              /* push edx */
            ii(0x1010_0690, 1); push(esi);                              /* push esi */
            ii(0x1010_0691, 1); push(edi);                              /* push edi */
            ii(0x1010_0692, 1); push(ebp);                              /* push ebp */
            ii(0x1010_0693, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_0695, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_069b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_069e, 5); mov(eax, memd[ds, 0x101c_3964]);        /* mov eax, [0x101c3964] */
            ii(0x1010_06a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_06a6, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1010_06a9, 2); if(jnz(0x1010_06b9, 0xe)) goto l_0x1010_06b9; /* jnz 0x101006b9 */
            ii(0x1010_06ab, 6); mov(ax, memw[ds, 0x101c_3968]);         /* mov ax, [0x101c3968] */
            ii(0x1010_06b1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_06b4, 5); jmp(0x1010_0732, 0x79); goto l_0x1010_0732; /* jmp 0x10100732 */
        l_0x1010_06b9:
            ii(0x1010_06b9, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_06c0, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_06c7, 2); jmp(0x1010_06cf, 6); goto l_0x1010_06cf; /* jmp 0x101006cf */
        l_0x1010_06c9:
            ii(0x1010_06c9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_06cc, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1010_06cf:
            ii(0x1010_06cf, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_06d3, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1010_06d6, 2); if(jge(0x1010_0732, 0x5a)) goto l_0x1010_0732; /* jge 0x10100732 */
            ii(0x1010_06d8, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_06dc, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_06e2, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1010_06e8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_06ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_06ef, 2); if(jz(0x1010_070b, 0x1a)) goto l_0x1010_070b; /* jz 0x1010070b */
            ii(0x1010_06f1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_06f5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_06fb, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1010_0701, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_0706, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1010_0709, 2); if(jnz(0x1010_070d, 2)) goto l_0x1010_070d; /* jnz 0x1010070d */
        l_0x1010_070b:
            ii(0x1010_070b, 2); jmp(0x1010_0730, 0x23); goto l_0x1010_0730; /* jmp 0x10100730 */
        l_0x1010_070d:
            ii(0x1010_070d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_0710, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1010_0713, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_0718, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_071e, 6); mov(edx, memd[ds, eax + 0x101c_a550]);  /* mov edx, [eax+0x101ca550] */
            ii(0x1010_0724, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0728, 5); call(0x1007_6e7c, -0x8_98b1);           /* call 0x10076e7c */
            ii(0x1010_072d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1010_0730:
            ii(0x1010_0730, 2); jmp(0x1010_06c9, -0x69); goto l_0x1010_06c9; /* jmp 0x101006c9 */
        l_0x1010_0732:
            ii(0x1010_0732, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0736, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1010_0739, 2); if(jge(0x1010_0742, 7)) goto l_0x1010_0742; /* jge 0x10100742 */
            ii(0x1010_073b, 7); mov(memd[ss, ebp - 8], 0xa);            /* mov dword [ebp-0x8], 0xa */
        l_0x1010_0742:
            ii(0x1010_0742, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1010_0746, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1010_0749, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1010_074e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_0750, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_0753, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_0755, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_0758, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_075c, 1); push(eax);                              /* push eax */
            ii(0x1010_075d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_0760, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0762, 4); mov(ax, memw[ds, edx + 0x52]);          /* mov ax, [edx+0x52] */
            ii(0x1010_0766, 1); push(eax);                              /* push eax */
            ii(0x1010_0767, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_076a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_076c, 4); mov(cx, memw[ds, edx + 0x52]);          /* mov cx, [edx+0x52] */
            ii(0x1010_0770, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_0775, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_077a, 5); mov(eax, StringDefinitions.Points);     /* mov eax, 0x101a2b67 */
            ii(0x1010_077f, 5); call(0x100f_ff95, -0x7ef);              /* call 0x100fff95 */
            ii(0x1010_0784, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_0788, 1); push(eax);                              /* push eax */
            ii(0x1010_0789, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_078b, 4); mov(ax, memw[ss, ebp - 8]);             /* mov ax, [ebp-0x8] */
            ii(0x1010_078f, 1); push(eax);                              /* push eax */
            ii(0x1010_0790, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_0793, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0795, 3); mov(cl, memb[ds, edx + 0x26]);          /* mov cl, [edx+0x26] */
            ii(0x1010_0798, 6); imul(ecx, ecx, 0x247);                  /* imul ecx, ecx, 0x247 */
            ii(0x1010_079e, 7); mov(cx, memw[ds, ecx + 0x101c_a550]);   /* mov cx, [ecx+0x101ca550] */
            ii(0x1010_07a5, 6); and(ecx, 0xffff);                       /* and ecx, 0xffff */
            ii(0x1010_07ab, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_07b0, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_07b5, 5); mov(eax, StringDefinitions.Total4);     /* mov eax, 0x101a2b6e */
            ii(0x1010_07ba, 5); call(0x100f_ff95, -0x82a);              /* call 0x100fff95 */
            ii(0x1010_07bf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_07c1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_07c2, 1); pop(edi);                               /* pop edi */
            ii(0x1010_07c3, 1); pop(esi);                               /* pop esi */
            ii(0x1010_07c4, 1); pop(edx);                               /* pop edx */
            ii(0x1010_07c5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_07c6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_07c7, 1); ret();                                  /* ret */
        }
    }
}
