using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_585f-c5c16b14")]
        public void Method_1016_585f()
        {
            ii(0x1016_585f, 5); push(0x54);                             /* push 0x54 */
            ii(0x1016_5864, 5); call(Definitions.sys_check_available_stack_size, 0x4e9); /* call 0x10165d52 */
            ii(0x1016_5869, 1); push(ebx);                              /* push ebx */
            ii(0x1016_586a, 1); push(ecx);                              /* push ecx */
            ii(0x1016_586b, 1); push(edx);                              /* push edx */
            ii(0x1016_586c, 1); push(esi);                              /* push esi */
            ii(0x1016_586d, 1); push(edi);                              /* push edi */
            ii(0x1016_586e, 1); push(ebp);                              /* push ebp */
            ii(0x1016_586f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_5871, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1016_5877, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_587a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1016_587f, 5); call(/* sys */ 0x1016_a24c, 0x49c8);    /* call 0x1016a24c */
            ii(0x1016_5884, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1016_5889, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x1016_588c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_588f, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1016_5892, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_5895, 5); call(/* sys */ 0x1016_5df8, 0x55e);     /* call 0x10165df8 */
            ii(0x1016_589a, 5); call(/* sys */ 0x1017_93f8, 0x1_3b59);  /* call 0x101793f8 */
            ii(0x1016_589f, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1016_58a4, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1016_58a7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_58aa, 3); mov(ecx, memd[ds, eax + 0x41]);         /* mov ecx, [eax+0x41] */
            ii(0x1016_58ad, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1016_58b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_58b3, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1016_58b6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_58b9, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1016_58bb, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_58bd, 5); call(/* sys */ 0x1017_93f8, 0x1_3b36);  /* call 0x101793f8 */
            ii(0x1016_58c2, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1016_58c7, 3); lea(edx, memd[ss, ebp - 0x20]);         /* lea edx, [ebp-0x20] */
            ii(0x1016_58ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_58cd, 3); mov(eax, memd[ds, eax + 0x43]);         /* mov eax, [eax+0x43] */
            ii(0x1016_58d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_58d3, 3); mov(ecx, memd[ss, ebp - 0x4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1016_58d6, 3); mov(ecx, memd[ds, ecx + 0x15]);         /* mov ecx, [ecx+0x15] */
            ii(0x1016_58d9, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1016_58dc, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_58de, 5); call(/* sys */ 0x1017_93f8, 0x1_3b15);  /* call 0x101793f8 */
            ii(0x1016_58e3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_58e6, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_58e9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_58ec, 3); mov(eax, memd[ds, eax + 0x64]);         /* mov eax, [eax+0x64] */
            ii(0x1016_58ef, 5); call(0x100d_7f6c, -0x8_d988);           /* call 0x100d7f6c */
            ii(0x1016_58f4, 5); call(0x100d_531c, -0x9_05dd);           /* call 0x100d531c */
            ii(0x1016_58f9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_58fe, 1); push(eax);                              /* push eax */
            ii(0x1016_58ff, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_5904, 1); push(eax);                              /* push eax */
            ii(0x1016_5905, 5); push(0xff);                             /* push 0xff */
            ii(0x1016_590a, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1016_590f, 1); push(eax);                              /* push eax */
            ii(0x1016_5910, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1016_5915, 1); push(eax);                              /* push eax */
            ii(0x1016_5916, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1016_591b, 1); push(eax);                              /* push eax */
            ii(0x1016_591c, 5); mov(ecx, 0x8d);                         /* mov ecx, 0x8d */
            ii(0x1016_5921, 3); lea(ebx, memd[ss, ebp - 0x10]);         /* lea ebx, [ebp-0x10] */
            ii(0x1016_5924, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_5927, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_592a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_592d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5930, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_5933, 5); call(0x100e_9ae5, -0x7_be53);           /* call 0x100e9ae5 */
            ii(0x1016_5938, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_593b, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_593e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5941, 3); mov(eax, memd[ds, eax + 0x68]);         /* mov eax, [eax+0x68] */
            ii(0x1016_5944, 5); call(0x100d_7f6c, -0x8_d9dd);           /* call 0x100d7f6c */
            ii(0x1016_5949, 5); call(0x100d_531c, -0x9_0632);           /* call 0x100d531c */
            ii(0x1016_594e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_5953, 1); push(eax);                              /* push eax */
            ii(0x1016_5954, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_5959, 1); push(eax);                              /* push eax */
            ii(0x1016_595a, 5); push(0xff);                             /* push 0xff */
            ii(0x1016_595f, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1016_5964, 1); push(eax);                              /* push eax */
            ii(0x1016_5965, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x1016_596a, 1); push(eax);                              /* push eax */
            ii(0x1016_596b, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1016_5970, 1); push(eax);                              /* push eax */
            ii(0x1016_5971, 5); mov(ecx, 0x1c);                         /* mov ecx, 0x1c */
            ii(0x1016_5976, 3); lea(ebx, memd[ss, ebp - 0x18]);         /* lea ebx, [ebp-0x18] */
            ii(0x1016_5979, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_597c, 3); mov(edx, memd[ds, edx + 0x31]);         /* mov edx, [edx+0x31] */
            ii(0x1016_597f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_5982, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5985, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_5988, 5); call(0x100e_9ae5, -0x7_bea8);           /* call 0x100e9ae5 */
            ii(0x1016_598d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_5990, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_5993, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5996, 3); mov(eax, memd[ds, eax + 0x6c]);         /* mov eax, [eax+0x6c] */
            ii(0x1016_5999, 5); call(0x100d_7f6c, -0x8_da32);           /* call 0x100d7f6c */
            ii(0x1016_599e, 5); call(0x100d_531c, -0x9_0687);           /* call 0x100d531c */
            ii(0x1016_59a3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_59a8, 1); push(eax);                              /* push eax */
            ii(0x1016_59a9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_59ae, 1); push(eax);                              /* push eax */
            ii(0x1016_59af, 5); push(0xff);                             /* push 0xff */
            ii(0x1016_59b4, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1016_59b9, 1); push(eax);                              /* push eax */
            ii(0x1016_59ba, 5); mov(eax, 0x3c);                         /* mov eax, 0x3c */
            ii(0x1016_59bf, 1); push(eax);                              /* push eax */
            ii(0x1016_59c0, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1016_59c5, 1); push(eax);                              /* push eax */
            ii(0x1016_59c6, 5); mov(ecx, 0xdf);                         /* mov ecx, 0xdf */
            ii(0x1016_59cb, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x1016_59ce, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_59d1, 3); mov(edx, memd[ds, eax + 0x31]);         /* mov edx, [eax+0x31] */
            ii(0x1016_59d4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_59d7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_59da, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_59dd, 5); call(0x100e_9ae5, -0x7_befd);           /* call 0x100e9ae5 */
            ii(0x1016_59e2, 5); call(0x100d_51e4, -0x9_0803);           /* call 0x100d51e4 */
            ii(0x1016_59e7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_59e9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1016_59eb, 5); call(0x100d_5204, -0x9_07ec);           /* call 0x100d5204 */
            ii(0x1016_59f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_59f2, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_59f4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_59f7, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_59fa, 5); call(0x100c_fa7c, -0x9_5f83);           /* call 0x100cfa7c */
            ii(0x1016_59ff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5a02, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1016_5a05, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_5a08, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_5a0a, 2); if(jl(0x1016_5a12, 0x6)) goto l_0x1016_5a12; /* jl 0x10165a12 */
            ii(0x1016_5a0c, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1016_5a10, 2); jmp(0x1016_5a16, 0x4); goto l_0x1016_5a16; /* jmp 0x10165a16 */
        l_0x1016_5a12:
            ii(0x1016_5a12, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1016_5a16:
            ii(0x1016_5a16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_5a18, 3); mov(dl, memb[ss, ebp - 0x8]);           /* mov dl, [ebp-0x8] */
            ii(0x1016_5a1b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5a1e, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_5a21, 5); call(0x100c_fb73, -0x9_5eb3);           /* call 0x100cfb73 */
            ii(0x1016_5a26, 5); call(0x100d_51c4, -0x9_0867);           /* call 0x100d51c4 */
            ii(0x1016_5a2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_5a2d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_5a2f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5a32, 3); mov(eax, memd[ds, eax + 0x5c]);         /* mov eax, [eax+0x5c] */
            ii(0x1016_5a35, 5); call(0x100c_fb06, -0x9_5f34);           /* call 0x100cfb06 */
            ii(0x1016_5a3a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_5a3d, 3); add(edx, 0x23);                         /* add edx, 0x23 */
            ii(0x1016_5a40, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_5a43, 3); mov(eax, memd[ds, eax + 0x35]);         /* mov eax, [eax+0x35] */
            ii(0x1016_5a46, 5); call(Definitions.sys_display_draw_1, 0x1a5d); /* call 0x101674a8 */
            ii(0x1016_5a4b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5a4d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_5a4e, 1); pop(edi);                               /* pop edi */
            ii(0x1016_5a4f, 1); pop(esi);                               /* pop esi */
            ii(0x1016_5a50, 1); pop(edx);                               /* pop edx */
            ii(0x1016_5a51, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_5a52, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_5a53, 1); ret();                                  /* ret */
        }
    }
}
