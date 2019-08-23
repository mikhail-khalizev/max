using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_7381-2fad8c6b")]
        public void Method_1007_7381()
        {
            ii(0x1007_7381, 5); push(0x90);                             /* push 0x90 */
            ii(0x1007_7386, 5); call(Definitions.sys_check_available_stack_size, 0xe_e9c7); /* call 0x10165d52 */
            ii(0x1007_738b, 1); push(esi);                              /* push esi */
            ii(0x1007_738c, 1); push(edi);                              /* push edi */
            ii(0x1007_738d, 1); push(ebp);                              /* push ebp */
            ii(0x1007_738e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_7390, 6); sub(esp, 0x7c);                         /* sub esp, 0x7c */
            ii(0x1007_7396, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_7399, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1007_739c, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_739f, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1007_73a2, 4); movsx(ebx, memw[ss, ebp + 0x14]);       /* movsx ebx, word [ebp+0x14] */
            ii(0x1007_73a6, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_73a9, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1007_73ac, 5); call(0x1007_5e64, -0x154d);             /* call 0x10075e64 */
            ii(0x1007_73b1, 3); lea(ecx, ebp - 0x34);                   /* lea ecx, [ebp-0x34] */
            ii(0x1007_73b4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_73b6, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1007_73b8, 5); call(0x100a_95c1, 0x3_2204);            /* call 0x100a95c1 */
            ii(0x1007_73bd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_73c0, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_73c3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_73c8, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1007_73ce, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_73d3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_73d5, 5); call(0x1008_a0c8, 0x1_2cee);            /* call 0x1008a0c8 */
            ii(0x1007_73da, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1007_73dd, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_73e1, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1007_73e4, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_73e7, 4); or(memb[ss, ebp - 0x20], 0x1);          /* or byte [ebp-0x20], 0x1 */
            ii(0x1007_73eb, 5); call(0x1008_a6d4, 0x1_32e4);            /* call 0x1008a6d4 */
            ii(0x1007_73f0, 1); cwde();                                 /* cwde */
            ii(0x1007_73f1, 1); push(eax);                              /* push eax */
            ii(0x1007_73f2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_73f4, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1007_73f9, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_73fc, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1007_73ff, 5); call(0x1011_fec1, 0xa_8abd);            /* call 0x1011fec1 */
            ii(0x1007_7404, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1007_7407, 4); and(memb[ss, ebp - 0x20], -0x2 /* 0xfe */); /* and byte [ebp-0x20], 0xfe */
            ii(0x1007_740b, 4); cmp(memb[ss, ebp + 0x18], 0);           /* cmp byte [ebp+0x18], 0x0 */
            ii(0x1007_740f, 2); if(jz(0x1007_7451, 0x40)) goto l_0x1007_7451; /* jz 0x10077451 */
            ii(0x1007_7411, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7414, 5); call(0x1007_623c, -0x11dd);             /* call 0x1007623c */
            ii(0x1007_7419, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_741c, 3); mov(dl, memb[ds, edx + 0x4e]);          /* mov dl, [edx+0x4e] */
            ii(0x1007_741f, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1007_7421, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1007_7425, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_7427, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_742a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_742d, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_7430, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_7433, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1007_7436, 6); mov(al, memb[ds, eax + 0x101c_81d4]);   /* mov al, [eax+0x101c81d4] */
            ii(0x1007_743c, 2); and(al, 0x3);                           /* and al, 0x3 */
            ii(0x1007_743e, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x1007_7440, 2); if(jnz(0x1007_744b, 0x9)) goto l_0x1007_744b; /* jnz 0x1007744b */
            ii(0x1007_7442, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7445, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1007_7449, 2); if(jz(0x1007_744d, 0x2)) goto l_0x1007_744d; /* jz 0x1007744d */
        l_0x1007_744b:
            ii(0x1007_744b, 2); jmp(0x1007_7451, 0x4); goto l_0x1007_7451; /* jmp 0x10077451 */
        l_0x1007_744d:
            ii(0x1007_744d, 4); mov(memb[ss, ebp + 0x18], 0);           /* mov byte [ebp+0x18], 0x0 */
        l_0x1007_7451:
            ii(0x1007_7451, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_7454, 4); imul(eax, memd[ss, ebp - 0x3c]);        /* imul eax, [ebp-0x3c] */
            ii(0x1007_7458, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_745b, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1007_7460, 4); movsx(ebx, memb[ss, ebp + 0x10]);       /* movsx ebx, byte [ebp+0x10] */
            ii(0x1007_7464, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_7467, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_746a, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_746d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7472, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1007_7478, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_747d, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_747f, 5); call(0x100c_1fd4, 0x4_ab50);            /* call 0x100c1fd4 */
            ii(0x1007_7484, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1007_7487, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_748a, 5); mov(memw[ds, eax], 0x7fff);             /* mov word [eax], 0x7fff */
            ii(0x1007_748f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_7492, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1007_7495, 5); call(0x1007_5e64, -0x1636);             /* call 0x10075e64 */
            ii(0x1007_749a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_749c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_749f, 5); call(0x1007_0ca1, -0x6803);             /* call 0x10070ca1 */
            ii(0x1007_74a4, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1007_74a7, 7); mov(memd[ss, ebp - 0x60], 0);           /* mov dword [ebp-0x60], 0x0 */
            ii(0x1007_74ae, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_74b1, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1007_74b4, 5); call(0x1007_5e64, -0x1655);             /* call 0x10075e64 */
            ii(0x1007_74b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_74bb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_74be, 5); call(0x1007_0ca1, -0x6822);             /* call 0x10070ca1 */
            ii(0x1007_74c3, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1007_74c6, 4); movsx(edx, memw[ss, ebp + 0x14]);       /* movsx edx, word [ebp+0x14] */
            ii(0x1007_74ca, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1007_74ce, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1007_74d1, 4); movsx(edx, memw[ss, ebp - 0x68]);       /* movsx edx, word [ebp-0x68] */
            ii(0x1007_74d5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_74d7, 2); if(jg(0x1007_74e2, 0x9)) goto l_0x1007_74e2; /* jg 0x100774e2 */
            ii(0x1007_74d9, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1007_74dc, 4); cmp(ax, memw[ss, ebp - 0x3c]);          /* cmp ax, [ebp-0x3c] */
            ii(0x1007_74e0, 2); if(jle(0x1007_74e4, 0x2)) goto l_0x1007_74e4; /* jle 0x100774e4 */
        l_0x1007_74e2:
            ii(0x1007_74e2, 2); jmp(0x1007_7539, 0x55); goto l_0x1007_7539; /* jmp 0x10077539 */
        l_0x1007_74e4:
            ii(0x1007_74e4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_74e7, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1007_74eb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_74ee, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1007_74f1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_74f4, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1007_74f8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_74fb, 4); mov(memw[ds, eax + 0x2], dx);           /* mov [eax+0x2], dx */
            ii(0x1007_74ff, 7); mov(memd[ss, ebp - 0x5c], 0);           /* mov dword [ebp-0x5c], 0x0 */
            ii(0x1007_7506, 4); cmp(memd[ss, ebp - 0x54], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1007_750a, 2); if(jz(0x1007_752c, 0x20)) goto l_0x1007_752c; /* jz 0x1007752c */
            ii(0x1007_750c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_750f, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1007_7512, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_7515, 3); add(edx, memd[ss, ebp - 0x54]);         /* add edx, [ebp-0x54] */
            ii(0x1007_7518, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_751b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_751d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_7520, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_7522, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1007_7524, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_7526, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1007_7529, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
        l_0x1007_752c:
            ii(0x1007_752c, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_752f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_7532, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1007_7535, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
        l_0x1007_7539:
            ii(0x1007_7539, 4); cmp(memd[ss, ebp - 0x54], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1007_753d, 2); if(jz(0x1007_7565, 0x26)) goto l_0x1007_7565; /* jz 0x10077565 */
            ii(0x1007_753f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_7542, 5); call(0x1008_9860, 0x1_2319);            /* call 0x10089860 */
            ii(0x1007_7547, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_754a, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_754d, 3); add(edx, memd[ss, ebp - 0x54]);         /* add edx, [ebp-0x54] */
            ii(0x1007_7550, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_7553, 5); call(0x1008_982c, 0x1_22d4);            /* call 0x1008982c */
            ii(0x1007_7558, 1); cwde();                                 /* cwde */
            ii(0x1007_7559, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_755b, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1007_755d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_755f, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1007_7562, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
        l_0x1007_7565:
            ii(0x1007_7565, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_7568, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_756b, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1007_756e, 2); if(jle(0x1007_757d, 0xd)) goto l_0x1007_757d; /* jle 0x1007757d */
            ii(0x1007_7570, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1007_7573, 4); cmp(ax, memw[ss, ebp - 0x3c]);          /* cmp ax, [ebp-0x3c] */
            ii(0x1007_7577, 6); if(jle(0x1007_76bc, 0x13f)) goto l_0x1007_76bc; /* jle 0x100776bc */
        l_0x1007_757d:
            ii(0x1007_757d, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_7580, 5); call(0x1008_9894, 0x1_230f);            /* call 0x10089894 */
            ii(0x1007_7585, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7587, 3); lea(eax, ebp - 0x6c);                   /* lea eax, [ebp-0x6c] */
            ii(0x1007_758a, 5); call(0x1007_5e64, -0x172b);             /* call 0x10075e64 */
            ii(0x1007_758f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7591, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7594, 5); call(0x1007_0ca1, -0x68f8);             /* call 0x10070ca1 */
            ii(0x1007_7599, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1007_759c, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_759f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_75a2, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1007_75a5, 2); if(jg(0x1007_75cd, 0x26)) goto l_0x1007_75cd; /* jg 0x100775cd */
            ii(0x1007_75a7, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_75aa, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_75ad, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1007_75b0, 2); if(jl(0x1007_75bb, 0x9)) goto l_0x1007_75bb; /* jl 0x100775bb */
            ii(0x1007_75b2, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1007_75b5, 4); cmp(ax, memw[ss, ebp - 0x5c]);          /* cmp ax, [ebp-0x5c] */
            ii(0x1007_75b9, 2); if(jge(0x1007_75c1, 0x6)) goto l_0x1007_75c1; /* jge 0x100775c1 */
        l_0x1007_75bb:
            ii(0x1007_75bb, 4); mov(memb[ss, ebp - 0x70], 0x1);         /* mov byte [ebp-0x70], 0x1 */
            ii(0x1007_75bf, 2); jmp(0x1007_75c5, 0x4); goto l_0x1007_75c5; /* jmp 0x100775c5 */
        l_0x1007_75c1:
            ii(0x1007_75c1, 4); mov(memb[ss, ebp - 0x70], 0);           /* mov byte [ebp-0x70], 0x0 */
        l_0x1007_75c5:
            ii(0x1007_75c5, 3); mov(al, memb[ss, ebp - 0x70]);          /* mov al, [ebp-0x70] */
            ii(0x1007_75c8, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x1007_75cb, 2); jmp(0x1007_75e6, 0x19); goto l_0x1007_75e6; /* jmp 0x100775e6 */
        l_0x1007_75cd:
            ii(0x1007_75cd, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1007_75d0, 4); cmp(ax, memw[ss, ebp - 0x3c]);          /* cmp ax, [ebp-0x3c] */
            ii(0x1007_75d4, 2); if(jg(0x1007_75dc, 0x6)) goto l_0x1007_75dc; /* jg 0x100775dc */
            ii(0x1007_75d6, 4); mov(memb[ss, ebp - 0x74], 0x1);         /* mov byte [ebp-0x74], 0x1 */
            ii(0x1007_75da, 2); jmp(0x1007_75e0, 0x4); goto l_0x1007_75e0; /* jmp 0x100775e0 */
        l_0x1007_75dc:
            ii(0x1007_75dc, 4); mov(memb[ss, ebp - 0x74], 0);           /* mov byte [ebp-0x74], 0x0 */
        l_0x1007_75e0:
            ii(0x1007_75e0, 3); mov(al, memb[ss, ebp - 0x74]);          /* mov al, [ebp-0x74] */
            ii(0x1007_75e3, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
        l_0x1007_75e6:
            ii(0x1007_75e6, 4); cmp(memb[ss, ebp - 0x18], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1007_75ea, 6); if(jz(0x1007_76bc, 0xcc)) goto l_0x1007_76bc; /* jz 0x100776bc */
            ii(0x1007_75f0, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1007_75f4, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1007_75f8, 2); if(jz(0x1007_7621, 0x27)) goto l_0x1007_7621; /* jz 0x10077621 */
            ii(0x1007_75fa, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_75fd, 5); call(0x1008_9860, 0x1_225e);            /* call 0x10089860 */
            ii(0x1007_7602, 1); cwde();                                 /* cwde */
            ii(0x1007_7603, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_7606, 3); mov(edx, memd[ss, ebp - 0x38]);         /* mov edx, [ebp-0x38] */
            ii(0x1007_7609, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_760b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_760e, 5); call(0x1008_982c, 0x1_2219);            /* call 0x1008982c */
            ii(0x1007_7613, 1); cwde();                                 /* cwde */
            ii(0x1007_7614, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1007_7616, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_7618, 3); test(memb[ds, eax], 0x8);               /* test byte [eax], 0x8 */
            ii(0x1007_761b, 6); if(jnz(0x1007_7691, 0x70)) goto l_0x1007_7691; /* jnz 0x10077691 */
        l_0x1007_7621:
            ii(0x1007_7621, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1007_7626, 1); push(eax);                              /* push eax */
            ii(0x1007_7627, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_762a, 5); call(0x1008_982c, 0x1_21fd);            /* call 0x1008982c */
            ii(0x1007_762f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1007_7632, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_7635, 5); call(0x1008_9860, 0x1_2226);            /* call 0x10089860 */
            ii(0x1007_763a, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_763d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7640, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_7643, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_7645, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_7648, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_764b, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_764e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_7651, 5); call(0x1007_02b9, -0x739d);             /* call 0x100702b9 */
            ii(0x1007_7656, 1); cwde();                                 /* cwde */
            ii(0x1007_7657, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7659, 2); if(jz(0x1007_7691, 0x36)) goto l_0x1007_7691; /* jz 0x10077691 */
            ii(0x1007_765b, 4); cmp(memb[ss, ebp + 0x18], 0);           /* cmp byte [ebp+0x18], 0x0 */
            ii(0x1007_765f, 2); if(jz(0x1007_7681, 0x20)) goto l_0x1007_7681; /* jz 0x10077681 */
            ii(0x1007_7661, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_7664, 5); call(0x1008_9894, 0x1_222b);            /* call 0x10089894 */
            ii(0x1007_7669, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_766b, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1007_766e, 5); call(0x1007_5e64, -0x180f);             /* call 0x10075e64 */
            ii(0x1007_7673, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_7675, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1007_7678, 5); call(0x1011_ff4c, 0xa_88cf);            /* call 0x1011ff4c */
            ii(0x1007_767d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_767f, 2); if(jz(0x1007_7687, 0x6)) goto l_0x1007_7687; /* jz 0x10077687 */
        l_0x1007_7681:
            ii(0x1007_7681, 4); mov(memb[ss, ebp - 0x78], 0x1);         /* mov byte [ebp-0x78], 0x1 */
            ii(0x1007_7685, 2); jmp(0x1007_768b, 0x4); goto l_0x1007_768b; /* jmp 0x1007768b */
        l_0x1007_7687:
            ii(0x1007_7687, 4); mov(memb[ss, ebp - 0x78], 0);           /* mov byte [ebp-0x78], 0x0 */
        l_0x1007_768b:
            ii(0x1007_768b, 3); mov(al, memb[ss, ebp - 0x78]);          /* mov al, [ebp-0x78] */
            ii(0x1007_768e, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
        l_0x1007_7691:
            ii(0x1007_7691, 4); cmp(memb[ss, ebp - 0x18], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1007_7695, 2); if(jz(0x1007_76bc, 0x25)) goto l_0x1007_76bc; /* jz 0x100776bc */
            ii(0x1007_7697, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_769b, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1007_769e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_76a1, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1007_76a4, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1007_76a7, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1007_76aa, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_76ad, 5); call(0x1008_9894, 0x1_21e2);            /* call 0x10089894 */
            ii(0x1007_76b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_76b4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_76b7, 5); call(0x1008_8b44, 0x1_1488);            /* call 0x10088b44 */
        l_0x1007_76bc:
            ii(0x1007_76bc, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1007_76bf, 5); call(0x100a_96db, 0x3_2017);            /* call 0x100a96db */
            ii(0x1007_76c4, 2); test(al, al);                           /* test al, al */
            ii(0x1007_76c6, 6); if(jnz(0x1007_7539, -0x193)) goto l_0x1007_7539; /* jnz 0x10077539 */
            ii(0x1007_76cc, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1007_76cf, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
            ii(0x1007_76d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_76d4, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1007_76d7, 5); call(Definitions.my_dtor_d1, 0x1_1620); /* call 0x10088cfc */
            ii(0x1007_76dc, 2); jmp(0x1007_76e8, 0xa); goto l_0x1007_76e8; /* jmp 0x100776e8 */
        //  ii(0x1007_76de, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_76e0, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
        //  ii(0x1007_76e3, 5); call(Definitions.my_dtor_d1, 0x1_1614); /* call 0x10088cfc */
        l_0x1007_76e8:
            ii(0x1007_76e8, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1007_76eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_76ed, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_76ee, 1); pop(edi);                               /* pop edi */
            ii(0x1007_76ef, 1); pop(esi);                               /* pop esi */
            ii(0x1007_76f0, 3); ret(0xc);                               /* ret 0xc */
        }
    }
}
