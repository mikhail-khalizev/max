using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_91fb-ab4d589b")]
        public void Method_1010_91fb()
        {
            ii(0x1010_91fb, 5); push(0x68);                             /* push 0x68 */
            ii(0x1010_9200, 5); call(Definitions.sys_check_available_stack_size, 0x5_cb4d); /* call 0x10165d52 */
            ii(0x1010_9205, 1); push(ebx);                              /* push ebx */
            ii(0x1010_9206, 1); push(ecx);                              /* push ecx */
            ii(0x1010_9207, 1); push(esi);                              /* push esi */
            ii(0x1010_9208, 1); push(edi);                              /* push edi */
            ii(0x1010_9209, 1); push(ebp);                              /* push ebp */
            ii(0x1010_920a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_920c, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1010_9212, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_9215, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_9218, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_921a, 5); call(0x100e_883d, -0x2_09e2);           /* call 0x100e883d */
            ii(0x1010_921f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_9221, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9224, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1010_9226, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_9229, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1010_922b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_922e, 3); mov(memb[ds, edx + 0x8], al);           /* mov [edx+0x8], al */
            ii(0x1010_9231, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9234, 3); mov(eax, memd[ds, eax + 0x5]);          /* mov eax, [eax+0x5] */
            ii(0x1010_9237, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1010_923a, 5); call(0x1007_5fdc, -0x9_3263);           /* call 0x10075fdc */
            ii(0x1010_923f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_9241, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9244, 4); mov(memw[ds, eax + 0x9], dx);           /* mov [eax+0x9], dx */
            ii(0x1010_9248, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_924b, 4); mov(dx, memw[ds, eax + 0x9]);           /* mov dx, [eax+0x9] */
            ii(0x1010_924f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9252, 4); mov(memw[ds, eax + 0xb], dx);           /* mov [eax+0xb], dx */
            ii(0x1010_9256, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9259, 7); mov(memd[ds, eax + 0x11], 0);           /* mov dword [eax+0x11], 0x0 */
            ii(0x1010_9260, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9263, 7); mov(memd[ds, eax + 0x4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x1010_926a, 5); call(/* sys */ 0x1016_be34, 0x6_2bc5);  /* call 0x1016be34 */
            ii(0x1010_926f, 5); call(0x100d_533c, -0x3_3f38);           /* call 0x100d533c */
            ii(0x1010_9274, 1); cwde();                                 /* cwde */
            ii(0x1010_9275, 1); push(eax);                              /* push eax */
            ii(0x1010_9276, 5); call(0x100d_5360, -0x3_3f1b);           /* call 0x100d5360 */
            ii(0x1010_927b, 1); cwde();                                 /* cwde */
            ii(0x1010_927c, 1); push(eax);                              /* push eax */
            ii(0x1010_927d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_927f, 1); push(eax);                              /* push eax */
            ii(0x1010_9280, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_9282, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9285, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1010_9287, 3); mov(ebx, memd[ds, ebx + 0xe]);          /* mov ebx, [ebx+0xe] */
            ii(0x1010_928a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_928d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9290, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_9292, 5); mov(eax, 0x6ce);                        /* mov eax, 0x6ce */
            ii(0x1010_9297, 5); call(0x100e_8c51, -0x2_064b);           /* call 0x100e8c51 */
            ii(0x1010_929c, 7); mov(memd[ss, ebp - 0xc], 0xc);          /* mov dword [ebp-0xc], 0xc */
        l_0x1010_92a3:
            ii(0x1010_92a3, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1010_92a6, 5); cmp(memw[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_92ab, 2); if(jz(0x1010_92d3, 0x26)) goto l_0x1010_92d3; /* jz 0x101092d3 */
            ii(0x1010_92ad, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_92b1, 3); cmp(eax, 0x7);                          /* cmp eax, 0x7 */
            ii(0x1010_92b4, 2); if(jg(0x1010_92bc, 0x6)) goto l_0x1010_92bc; /* jg 0x101092bc */
            ii(0x1010_92b6, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1010_92ba, 2); jmp(0x1010_92c0, 0x4); goto l_0x1010_92c0; /* jmp 0x101092c0 */
        l_0x1010_92bc:
            ii(0x1010_92bc, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1010_92c0:
            ii(0x1010_92c0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_92c2, 3); mov(bl, memb[ss, ebp - 0x10]);          /* mov bl, [ebp-0x10] */
            ii(0x1010_92c5, 4); movsx(edx, memb[ss, ebp - 0xc]);        /* movsx edx, byte [ebp-0xc] */
            ii(0x1010_92c9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_92cc, 5); call(0x1010_8ed4, -0x3fd);              /* call 0x10108ed4 */
            ii(0x1010_92d1, 2); jmp(0x1010_92a3, -0x30); goto l_0x1010_92a3; /* jmp 0x101092a3 */
        l_0x1010_92d3:
            ii(0x1010_92d3, 6); mov(memw[ss, ebp - 0xc], 0);            /* mov word [ebp-0xc], 0x0 */
            ii(0x1010_92d9, 2); jmp(0x1010_92e2, 0x7); goto l_0x1010_92e2; /* jmp 0x101092e2 */
        l_0x1010_92db:
            ii(0x1010_92db, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_92de, 4); inc(memw[ss, ebp - 0xc]);               /* inc word [ebp-0xc] */
        l_0x1010_92e2:
            ii(0x1010_92e2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_92e6, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1010_92e9, 2); if(jge(0x1010_930c, 0x21)) goto l_0x1010_930c; /* jge 0x1010930c */
            ii(0x1010_92eb, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_92ef, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_92f2, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_92f5, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1010_92f8, 5); call(0x100d_5104, -0x3_41f9);           /* call 0x100d5104 */
            ii(0x1010_92fd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_92ff, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_9303, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_9306, 4); mov(memd[ds, eax + ebp - 0x30], edx);   /* mov [eax+ebp-0x30], edx */
            ii(0x1010_930a, 2); jmp(0x1010_92db, -0x31); goto l_0x1010_92db; /* jmp 0x101092db */
        l_0x1010_930c:
            ii(0x1010_930c, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x1010_930f, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1010_9314, 5); call(/* sys */ 0x1016_9a78, 0x6_075f);  /* call 0x10169a78 */
            ii(0x1010_9319, 7); mov(memd[ss, ebp - 0x34], 0x101b_9a04); /* mov dword [ebp-0x34], 0x101b9a04 */
            ii(0x1010_9320, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_9325, 5); call(Definitions.sys_new, 0x5_cad6);    /* call 0x10165e00 */
            ii(0x1010_932a, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1010_932d, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1010_9330, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1010_9333, 4); cmp(memd[ss, ebp - 0x3c], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_9337, 2); if(jz(0x1010_937b, 0x42)) goto l_0x1010_937b; /* jz 0x1010937b */
            ii(0x1010_9339, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_933c, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1010_9340, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1010_9343, 4); sub(ax, memw[ds, edx + 0x4]);           /* sub ax, [edx+0x4] */
            ii(0x1010_9347, 1); cwde();                                 /* cwde */
            ii(0x1010_9348, 1); push(eax);                              /* push eax */
            ii(0x1010_9349, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_934c, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_9350, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1010_9353, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1010_9356, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_9359, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_935c, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1010_935f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_9362, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_9365, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1010_9368, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1010_936b, 5); call(0x100d_7bdc, -0x3_1794);           /* call 0x100d7bdc */
            ii(0x1010_9370, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1010_9373, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1010_9376, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1010_9379, 2); jmp(0x1010_9381, 0x6); goto l_0x1010_9381; /* jmp 0x10109381 */
        l_0x1010_937b:
            ii(0x1010_937b, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1010_937e, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x1010_9381:
            ii(0x1010_9381, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1010_9384, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_9387, 3); mov(memd[ds, edx + 0x11], eax);         /* mov [edx+0x11], eax */
            ii(0x1010_938a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_938d, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_938f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9392, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1010_9395, 5); call(0x100d_7d74, -0x3_1626);           /* call 0x100d7d74 */
            ii(0x1010_939a, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_939f, 5); call(/* sys */ 0x1016_a24c, 0x6_0ea8);  /* call 0x1016a24c */
            ii(0x1010_93a4, 5); call(0x1011_5318, 0xbf6f);              /* call 0x10115318 */
            ii(0x1010_93a9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_93ae, 1); push(eax);                              /* push eax */
            ii(0x1010_93af, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_93b4, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1010_93b9, 5); mov(edx, 0x101b_9950);                  /* mov edx, 0x101b9950 */
            ii(0x1010_93be, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_93c1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_93c3, 5); call(0x1010_8a05, -0x9c3);              /* call 0x10108a05 */
            ii(0x1010_93c8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_93cb, 5); call(0x1010_8b99, -0x837);              /* call 0x10108b99 */
            ii(0x1010_93d0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_93d3, 3); mov(eax, memd[ds, eax + 0x9]);          /* mov eax, [eax+0x9] */
            ii(0x1010_93d6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_93d9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_93db, 2); if(jz(0x1010_93f9, 0x1c)) goto l_0x1010_93f9; /* jz 0x101093f9 */
            ii(0x1010_93dd, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_93e2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_93e5, 3); mov(eax, memd[ds, eax + 0x9]);          /* mov eax, [eax+0x9] */
            ii(0x1010_93e8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_93eb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_93ee, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_93f1, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1010_93f4, 5); call(0x100c_fb73, -0x3_9886);           /* call 0x100cfb73 */
        l_0x1010_93f9:
            ii(0x1010_93f9, 5); call(/* sys */ 0x1016_bcc4, 0x6_28c6);  /* call 0x1016bcc4 */
            ii(0x1010_93fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_9400, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_9401, 1); pop(edi);                               /* pop edi */
            ii(0x1010_9402, 1); pop(esi);                               /* pop esi */
            ii(0x1010_9403, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_9404, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_9405, 1); ret();                                  /* ret */
        }
    }
}
