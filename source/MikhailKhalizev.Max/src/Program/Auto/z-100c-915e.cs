using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_915e-5fd178")]
        public void Method_100c_915e()
        {
            ii(0x100c_915e, 5); push(0x54);                             /* push 0x54 */
            ii(0x100c_9163, 5); call(Definitions.sys_check_available_stack_size, 0x9_cbea); /* call 0x10165d52 */
            ii(0x100c_9168, 1); push(ecx);                              /* push ecx */
            ii(0x100c_9169, 1); push(esi);                              /* push esi */
            ii(0x100c_916a, 1); push(edi);                              /* push edi */
            ii(0x100c_916b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_916c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_916e, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100c_9174, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_9177, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100c_917a, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100c_917d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_9180, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_9183, 5); call(0x1007_5e64, -0x5_3324);           /* call 0x10075e64 */
            ii(0x100c_9188, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_918c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_918f, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_9192, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_9195, 3); add(edx, memd[ss, ebp - 8]);            /* add edx, [ebp-0x8] */
            ii(0x100c_9198, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_919b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_919d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_91a0, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_91a2, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_91a4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_91a6, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_91a9, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x100c_91ac, 6); if(jnz(0x100c_938a, 0x1d8)) goto l_0x100c_938a; /* jnz 0x100c938a */
            ii(0x100c_91b2, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_91b9, 2); jmp(0x100c_91c1, 6); goto l_0x100c_91c1; /* jmp 0x100c91c1 */
        l_0x100c_91bb:
            ii(0x100c_91bb, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_91be, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x100c_91c1:
            ii(0x100c_91c1, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_91c5, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100c_91c8, 2); if(jge(0x100c_91e4, 0x1a)) goto l_0x100c_91e4; /* jge 0x100c91e4 */
            ii(0x100c_91ca, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_91ce, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_91d4, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_91da, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_91df, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100c_91e2, 2); if(jnz(0x100c_91bb, -0x29)) goto l_0x100c_91bb; /* jnz 0x100c91bb */
        l_0x100c_91e4:
            ii(0x100c_91e4, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_91e8, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100c_91eb, 6); if(jz(0x100c_938a, 0x199)) goto l_0x100c_938a; /* jz 0x100c938a */
            ii(0x100c_91f1, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100c_91f6, 5); call(Definitions.sys_new, 0x9_cc05);    /* call 0x10165e00 */
            ii(0x100c_91fb, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_91fe, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_9201, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_9204, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100c_9208, 2); if(jz(0x100c_9221, 0x17)) goto l_0x100c_9221; /* jz 0x100c9221 */
            ii(0x100c_920a, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_920e, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_9211, 5); call(0x100c_9677, 0x461);               /* call 0x100c9677 */
            ii(0x100c_9216, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100c_9219, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100c_921c, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100c_921f, 2); jmp(0x100c_9227, 6); goto l_0x100c_9227; /* jmp 0x100c9227 */
        l_0x100c_9221:
            ii(0x100c_9221, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_9224, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x100c_9227:
            ii(0x100c_9227, 3); mov(edx, memd[ss, ebp - 0x38]);         /* mov edx, [ebp-0x38] */
            ii(0x100c_922a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_922f, 5); call(0x100a_4d50, -0x2_44e4);           /* call 0x100a4d50 */
            ii(0x100c_9234, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_9237, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_923a, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_923d, 3); add(edx, memd[ss, ebp - 8]);            /* add edx, [ebp-0x8] */
            ii(0x100c_9240, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_9243, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9245, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9248, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_924a, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_924c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_924e, 5); mov(memw[ds, eax], 0xffff);             /* mov word [eax], 0xffff */
            ii(0x100c_9253, 7); mov(memd[ss, ebp - 0x20], 1);           /* mov dword [ebp-0x20], 0x1 */
            ii(0x100c_925a, 2); jmp(0x100c_9262, 6); goto l_0x100c_9262; /* jmp 0x100c9262 */
        l_0x100c_925c:
            ii(0x100c_925c, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_925f, 3); inc(memd[ss, ebp - 0x20]);              /* inc dword [ebp-0x20] */
        l_0x100c_9262:
            ii(0x100c_9262, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100c_9266, 6); if(jz(0x100c_938a, 0x11e)) goto l_0x100c_938a; /* jz 0x100c938a */
            ii(0x100c_926c, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100c_926f, 4); dec(memw[ss, ebp - 0x34]);              /* dec word [ebp-0x34] */
            ii(0x100c_9273, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x100c_9276, 4); inc(memw[ss, ebp - 0x32]);              /* inc word [ebp-0x32] */
            ii(0x100c_927a, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_927e, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_9285, 2); jmp(0x100c_928b, 4); goto l_0x100c_928b; /* jmp 0x100c928b */
        l_0x100c_9287:
            ii(0x100c_9287, 4); add(memd[ss, ebp - 0x1c], 2);           /* add dword [ebp-0x1c], 0x2 */
        l_0x100c_928b:
            ii(0x100c_928b, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_928f, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x100c_9292, 6); if(jge(0x100c_9385, 0xed)) goto l_0x100c_9385; /* jge 0x100c9385 */
            ii(0x100c_9298, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_929b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_929d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100c_92a0:
            ii(0x100c_92a0, 3); dec(memd[ss, ebp - 0x18]);              /* dec dword [ebp-0x18] */
            ii(0x100c_92a3, 5); cmp(memw[ss, ebp - 0x18], -1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x100c_92a8, 6); if(jz(0x100c_9380, 0xd2)) goto l_0x100c_9380; /* jz 0x100c9380 */
            ii(0x100c_92ae, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_92b2, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_92b5, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100c_92ba, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_92bc, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_92bf, 5); call(0x1008_b1a4, -0x3_e120);           /* call 0x1008b1a4 */
            ii(0x100c_92c4, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x100c_92c8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_92ca, 2); if(jl(0x100c_92d8, 0xc)) goto l_0x100c_92d8; /* jl 0x100c92d8 */
            ii(0x100c_92cc, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100c_92cf, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_92d6, 2); if(jl(0x100c_92da, 2)) goto l_0x100c_92da; /* jl 0x100c92da */
        l_0x100c_92d8:
            ii(0x100c_92d8, 2); jmp(0x100c_92e2, 8); goto l_0x100c_92e2; /* jmp 0x100c92e2 */
        l_0x100c_92da:
            ii(0x100c_92da, 4); movsx(eax, memw[ss, ebp - 0x32]);       /* movsx eax, word [ebp-0x32] */
            ii(0x100c_92de, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_92e0, 2); if(jge(0x100c_92e4, 2)) goto l_0x100c_92e4; /* jge 0x100c92e4 */
        l_0x100c_92e2:
            ii(0x100c_92e2, 2); jmp(0x100c_92f0, 0xc); goto l_0x100c_92f0; /* jmp 0x100c92f0 */
        l_0x100c_92e4:
            ii(0x100c_92e4, 3); mov(eax, memd[ss, ebp - 0x32]);         /* mov eax, [ebp-0x32] */
            ii(0x100c_92e7, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_92ee, 2); if(jl(0x100c_92f5, 5)) goto l_0x100c_92f5; /* jl 0x100c92f5 */
        l_0x100c_92f0:
            ii(0x100c_92f0, 5); jmp(0x100c_937b, 0x86); goto l_0x100c_937b; /* jmp 0x100c937b */
        l_0x100c_92f5:
            ii(0x100c_92f5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_92f8, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x100c_92fb, 5); call(0x1007_5e64, -0x5_349c);           /* call 0x10075e64 */
            ii(0x100c_9300, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9302, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x100c_9305, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_9308, 5); call(0x1007_5e64, -0x5_34a9);           /* call 0x10075e64 */
            ii(0x100c_930d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_930f, 5); call(0x1007_0c51, -0x5_86c3);           /* call 0x10070c51 */
            ii(0x100c_9314, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_9317, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x100c_931b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_931e, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100c_9321, 4); movsx(edx, memw[ss, ebp - 0x32]);       /* movsx edx, word [ebp-0x32] */
            ii(0x100c_9325, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_9327, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9329, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_932b, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100c_932e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_9331, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_9335, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x100c_933a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_933c, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_9340, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_9342, 2); if(jle(0x100c_937b, 0x37)) goto l_0x100c_937b; /* jle 0x100c937b */
            ii(0x100c_9344, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_9348, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x100c_934d, 5); cmp(eax, 0x7fff);                       /* cmp eax, 0x7fff */
            ii(0x100c_9352, 2); if(jz(0x100c_9358, 4)) goto l_0x100c_9358; /* jz 0x100c9358 */
            ii(0x100c_9354, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x100c_9358:
            ii(0x100c_9358, 3); mov(ebx, memd[ss, ebp - 0x24]);         /* mov ebx, [ebp-0x24] */
            ii(0x100c_935b, 6); and(ebx, 0x8000);                       /* and ebx, 0x8000 */
            ii(0x100c_9361, 3); or(ebx, memd[ss, ebp - 0x14]);          /* or ebx, [ebp-0x14] */
            ii(0x100c_9364, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x100c_9368, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_936b, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100c_936e, 4); movsx(edx, memw[ss, ebp - 0x32]);       /* movsx edx, word [ebp-0x32] */
            ii(0x100c_9372, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_9374, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9376, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_9378, 3); mov(memw[ds, eax], bx);                 /* mov [eax], bx */
        l_0x100c_937b:
            ii(0x100c_937b, 5); jmp(0x100c_92a0, -0xe0); goto l_0x100c_92a0; /* jmp 0x100c92a0 */
        l_0x100c_9380:
            ii(0x100c_9380, 5); jmp(0x100c_9287, -0xfe); goto l_0x100c_9287; /* jmp 0x100c9287 */
        l_0x100c_9385:
            ii(0x100c_9385, 5); jmp(0x100c_925c, -0x12e); goto l_0x100c_925c; /* jmp 0x100c925c */
        l_0x100c_938a:
            ii(0x100c_938a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_938c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_938d, 1); pop(edi);                               /* pop edi */
            ii(0x100c_938e, 1); pop(esi);                               /* pop esi */
            ii(0x100c_938f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_9390, 1); ret();                                  /* ret */
        }
    }
}
