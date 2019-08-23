using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_b2b0-6bf29dad")]
        public void /* sys */ Method_1017_b2b0()
        {
            ii(0x1017_b2b0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_b2b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b2b3, 1); push(ebx);                              /* push ebx */
            ii(0x1017_b2b4, 1); push(ecx);                              /* push ecx */
            ii(0x1017_b2b5, 1); push(edx);                              /* push edx */
            ii(0x1017_b2b6, 1); push(esi);                              /* push esi */
            ii(0x1017_b2b7, 1); push(edi);                              /* push edi */
            ii(0x1017_b2b8, 6); sub(esp, 0x118);                        /* sub esp, 0x118 */
            ii(0x1017_b2be, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1017_b2c1, 3); mov(ah, memb[ss, ebp - 0x23]);          /* mov ah, [ebp-0x23] */
            ii(0x1017_b2c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b2c6, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_b2c8, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1017_b2cb, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x1017_b2ce, 2); if(jz(0x1017_b2e4, 0x14)) goto l_0x1017_b2e4; /* jz 0x1017b2e4 */
            ii(0x1017_b2d0, 3); mov(ecx, memd[ss, ebp - 0x24]);         /* mov ecx, [ebp-0x24] */
            ii(0x1017_b2d3, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1017_b2d8, 6); and(ecx, 0x7fff);                       /* and ecx, 0x7fff */
            ii(0x1017_b2de, 3); mov(memd[ss, ebp - 0x1c], ebx);         /* mov [ebp-0x1c], ebx */
            ii(0x1017_b2e1, 3); mov(memd[ss, ebp - 0x24], ecx);         /* mov [ebp-0x24], ecx */
        l_0x1017_b2e4:
            ii(0x1017_b2e4, 3); mov(edi, memd[ss, ebp - 0x24]);         /* mov edi, [ebp-0x24] */
            ii(0x1017_b2e7, 6); cmp(edi, 0xf01);                        /* cmp edi, 0xf01 */
            ii(0x1017_b2ed, 2); if(jnz(0x1017_b323, 0x34)) goto l_0x1017_b323; /* jnz 0x1017b323 */
            ii(0x1017_b2ef, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1017_b2f4, 5); call(/* sys */ 0x1018_c6f0, 0x1_13f7);  /* call 0x1018c6f0 */
            ii(0x1017_b2f9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b2fb, 6); if(jz(0x1017_b55c, 0x25b)) goto l_0x1017_b55c; /* jz 0x1017b55c */
            ii(0x1017_b301, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1017_b306, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1017_b308, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_b309, 5); mov(edx, 0x3d5);                        /* mov edx, 0x3d5 */
            ii(0x1017_b30e, 2); mov(al, 0x2);                           /* mov al, 0x2 */
            ii(0x1017_b310, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_b311, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1017_b316, 5); mov(esi, 0xa0);                         /* mov esi, 0xa0 */
            ii(0x1017_b31b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1017_b31e, 5); jmp(0x1017_b3db, 0xb8); goto l_0x1017_b3db; /* jmp 0x1017b3db */
        l_0x1017_b323:
            ii(0x1017_b323, 6); cmp(edi, 0xf00);                        /* cmp edi, 0xf00 */
            ii(0x1017_b329, 2); if(jnz(0x1017_b36d, 0x42)) goto l_0x1017_b36d; /* jnz 0x1017b36d */
            ii(0x1017_b32b, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1017_b330, 5); call(/* sys */ 0x1018_c6f0, 0x1_13bb);  /* call 0x1018c6f0 */
            ii(0x1017_b335, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b337, 6); if(jz(0x1017_b55c, 0x21f)) goto l_0x1017_b55c; /* jz 0x1017b55c */
            ii(0x1017_b33d, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b33f, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b341, 5); mov(eax, 0xa7);                         /* mov eax, 0xa7 */
            ii(0x1017_b346, 5); mov(edx, 0x1a4);                        /* mov edx, 0x1a4 */
            ii(0x1017_b34b, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b34d, 5); mov(ebx, 0x15e);                        /* mov ebx, 0x15e */
            ii(0x1017_b352, 5); mov(ecx, 0x172);                        /* mov ecx, 0x172 */
            ii(0x1017_b357, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b359, 5); mov(esi, 0x15e);                        /* mov esi, 0x15e */
            ii(0x1017_b35e, 5); mov(edi, 0x101);                        /* mov edi, 0x101 */
            ii(0x1017_b363, 5); call(/* sys */ 0x1017_b140, -0x228);    /* call 0x1017b140 */
            ii(0x1017_b368, 3); mov(memd[ss, ebp - 0x24], edi);         /* mov [ebp-0x24], edi */
            ii(0x1017_b36b, 2); jmp(0x1017_b3db, 0x6e); goto l_0x1017_b3db; /* jmp 0x1017b3db */
        l_0x1017_b36d:
            ii(0x1017_b36d, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_b36f, 2); if(jz(0x1017_b3cb, 0x5a)) goto l_0x1017_b3cb; /* jz 0x1017b3cb */
            ii(0x1017_b371, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_b373, 5); call(/* sys */ 0x1018_c6f0, 0x1_1378);  /* call 0x1018c6f0 */
            ii(0x1017_b378, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b37a, 2); if(jnz(0x1017_b3db, 0x5f)) goto l_0x1017_b3db; /* jnz 0x1017b3db */
            ii(0x1017_b37c, 7); cmp(memd[ss, ebp - 0x24], 0x100);       /* cmp dword [ebp-0x24], 0x100 */
            ii(0x1017_b383, 6); if(jnz(0x1017_b55c, 0x1d3)) goto l_0x1017_b55c; /* jnz 0x1017b55c */
            ii(0x1017_b389, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1017_b38e, 5); call(/* sys */ 0x1018_c6f0, 0x1_135d);  /* call 0x1018c6f0 */
            ii(0x1017_b393, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b395, 6); if(jz(0x1017_b55c, 0x1c1)) goto l_0x1017_b55c; /* jz 0x1017b55c */
            ii(0x1017_b39b, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b39d, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b39f, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b3a1, 5); mov(eax, 0x63);                         /* mov eax, 0x63 */
            ii(0x1017_b3a6, 5); mov(edx, 0x1b0);                        /* mov edx, 0x1b0 */
            ii(0x1017_b3ab, 2); push(0);                                /* push 0x0 */
            ii(0x1017_b3ad, 5); mov(ebx, 0x190);                        /* mov ebx, 0x190 */
            ii(0x1017_b3b2, 5); mov(ecx, 0x198);                        /* mov ecx, 0x198 */
            ii(0x1017_b3b7, 5); call(/* sys */ 0x1017_b140, -0x27c);    /* call 0x1017b140 */
            ii(0x1017_b3bc, 5); mov(ecx, 0x101);                        /* mov ecx, 0x101 */
            ii(0x1017_b3c1, 5); mov(esi, 0x190);                        /* mov esi, 0x190 */
            ii(0x1017_b3c6, 3); mov(memd[ss, ebp - 0x24], ecx);         /* mov [ebp-0x24], ecx */
            ii(0x1017_b3c9, 2); jmp(0x1017_b3db, 0x10); goto l_0x1017_b3db; /* jmp 0x1017b3db */
        l_0x1017_b3cb:
            ii(0x1017_b3cb, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1017_b3ce, 5); call(/* sys */ 0x1018_c760, 0x1_138d);  /* call 0x1018c760 */
            ii(0x1017_b3d3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b3d5, 6); if(jz(0x1017_b55c, 0x181)) goto l_0x1017_b55c; /* jz 0x1017b55c */
        l_0x1017_b3db:
            ii(0x1017_b3db, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1017_b3de, 6); lea(edx, memd[ss, ebp - 0x12c]);        /* lea edx, [ebp-0x12c] */
            ii(0x1017_b3e4, 3); lea(ebx, memd[ss, ebp - 0x28]);         /* lea ebx, [ebp-0x28] */
            ii(0x1017_b3e7, 3); lea(ecx, memd[ss, ebp - 0x2c]);         /* lea ecx, [ebp-0x2c] */
            ii(0x1017_b3ea, 5); call(/* sys */ 0x1018_c560, 0x1_1171);  /* call 0x1018c560 */
            ii(0x1017_b3ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b3f1, 6); if(jz(0x1017_b55c, 0x165)) goto l_0x1017_b55c; /* jz 0x1017b55c */
            ii(0x1017_b3f7, 6); mov(al, memb[ss, ebp - 0x12a]);         /* mov al, [ebp-0x12a] */
            ii(0x1017_b3fd, 2); and(al, 0x5);                           /* and al, 0x5 */
            ii(0x1017_b3ff, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1017_b401, 2); if(jnz(0x1017_b40d, 0xa)) goto l_0x1017_b40d; /* jnz 0x1017b40d */
            ii(0x1017_b403, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b405, 3); mov(edi, memd[ss, ebp - 0x28]);         /* mov edi, [ebp-0x28] */
            ii(0x1017_b408, 3); mov(memd[ss, ebp - 0x18], ecx);         /* mov [ebp-0x18], ecx */
            ii(0x1017_b40b, 2); jmp(0x1017_b437, 0x2a); goto l_0x1017_b437; /* jmp 0x1017b437 */
        l_0x1017_b40d:
            ii(0x1017_b40d, 6); mov(al, memb[ss, ebp - 0x129]);         /* mov al, [ebp-0x129] */
            ii(0x1017_b413, 2); and(al, 0x5);                           /* and al, 0x5 */
            ii(0x1017_b415, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1017_b417, 2); if(jnz(0x1017_b426, 0xd)) goto l_0x1017_b426; /* jnz 0x1017b426 */
            ii(0x1017_b419, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1017_b41e, 3); mov(edi, memd[ss, ebp - 0x2c]);         /* mov edi, [ebp-0x2c] */
            ii(0x1017_b421, 3); mov(memd[ss, ebp - 0x18], ebx);         /* mov [ebp-0x18], ebx */
            ii(0x1017_b424, 2); jmp(0x1017_b437, 0x11); goto l_0x1017_b437; /* jmp 0x1017b437 */
        l_0x1017_b426:
            ii(0x1017_b426, 5); mov(eax, 0xa000_0000);                  /* mov eax, 0xa0000000 */
            ii(0x1017_b42b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b42d, 5); call(/* sys */ 0x1019_43d0, 0x1_8f9e);  /* call 0x101943d0 */
            ii(0x1017_b432, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1017_b435, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1017_b437:
            ii(0x1017_b437, 7); test(memb[ss, ebp - 0x12c], 0x2);       /* test byte [ebp-0x12c], 0x2 */
            ii(0x1017_b43e, 2); if(jz(0x1017_b454, 0x14)) goto l_0x1017_b454; /* jz 0x1017b454 */
            ii(0x1017_b440, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b442, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_b444, 7); mov(cx, memw[ss, ebp - 0x11a]);         /* mov cx, [ebp-0x11a] */
            ii(0x1017_b44b, 7); mov(bx, memw[ss, ebp - 0x118]);         /* mov bx, [ebp-0x118] */
            ii(0x1017_b452, 2); jmp(0x1017_b4a7, 0x53); goto l_0x1017_b4a7; /* jmp 0x1017b4a7 */
        l_0x1017_b454:
            ii(0x1017_b454, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1017_b457, 5); sub(eax, 0x100);                        /* sub eax, 0x100 */
            ii(0x1017_b45c, 3); cmp(eax, 0x7);                          /* cmp eax, 0x7 */
            ii(0x1017_b45f, 6); if(ja(0x1017_b55c, 0xf7)) goto l_0x1017_b55c; /* ja 0x1017b55c */
            ii(0x1017_b465, 8); 
            switch (jmp_abs_switch(memd[cs, eax * 4 + /* sys */ 0x1017_b290]))
            {
                case 0x1017_b46d:
                    goto l_0x1017_b46d;
                case 0x1017_b479:
                    goto l_0x1017_b479;
                case 0x1017_b485:
                    goto l_0x1017_b485;
                case 0x1017_b491:
                    goto l_0x1017_b491;
                case 0x1017_b49d:
                    goto l_0x1017_b49d;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax*4+0x1017b290] */
        l_0x1017_b46d:
            ii(0x1017_b46d, 5); mov(ecx, 0x280);                        /* mov ecx, 0x280 */
            ii(0x1017_b472, 5); mov(ebx, 0x190);                        /* mov ebx, 0x190 */
            ii(0x1017_b477, 2); jmp(0x1017_b4a7, 0x2e); goto l_0x1017_b4a7; /* jmp 0x1017b4a7 */
        l_0x1017_b479:
            ii(0x1017_b479, 5); mov(ecx, 0x280);                        /* mov ecx, 0x280 */
            ii(0x1017_b47e, 5); mov(ebx, 0x1e0);                        /* mov ebx, 0x1e0 */
            ii(0x1017_b483, 2); jmp(0x1017_b4a7, 0x22); goto l_0x1017_b4a7; /* jmp 0x1017b4a7 */
        l_0x1017_b485:
            ii(0x1017_b485, 5); mov(ecx, 0x320);                        /* mov ecx, 0x320 */
            ii(0x1017_b48a, 5); mov(ebx, 0x258);                        /* mov ebx, 0x258 */
            ii(0x1017_b48f, 2); jmp(0x1017_b4a7, 0x16); goto l_0x1017_b4a7; /* jmp 0x1017b4a7 */
        l_0x1017_b491:
            ii(0x1017_b491, 5); mov(ecx, 0x400);                        /* mov ecx, 0x400 */
            ii(0x1017_b496, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x1017_b49b, 2); jmp(0x1017_b4a7, 0xa); goto l_0x1017_b4a7; /* jmp 0x1017b4a7 */
        l_0x1017_b49d:
            ii(0x1017_b49d, 5); mov(ecx, 0x500);                        /* mov ecx, 0x500 */
            ii(0x1017_b4a2, 5); mov(ebx, 0x400);                        /* mov ebx, 0x400 */
        l_0x1017_b4a7:
            ii(0x1017_b4a7, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_b4a9, 2); if(jz(0x1017_b4ad, 0x2)) goto l_0x1017_b4ad; /* jz 0x1017b4ad */
            ii(0x1017_b4ab, 2); mov(ebx, esi);                          /* mov ebx, esi */
        l_0x1017_b4ad:
            ii(0x1017_b4ad, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1017_b4b1, 2); if(jz(0x1017_b4e6, 0x33)) goto l_0x1017_b4e6; /* jz 0x1017b4e6 */
            ii(0x1017_b4b3, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1017_b4b8, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1017_b4ba, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_b4bb, 5); mov(edx, 0x3d5);                        /* mov edx, 0x3d5 */
            ii(0x1017_b4c0, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1017_b4c2, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1017_b4c3, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1017_b4c6, 4); test(memb[ss, ebp - 0x20], 0x80);       /* test byte [ebp-0x20], 0x80 */
            ii(0x1017_b4ca, 2); if(jnz(0x1017_b4e6, 0x1a)) goto l_0x1017_b4e6; /* jnz 0x1017b4e6 */
            ii(0x1017_b4cc, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1017_b4d1, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1017_b4d3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_b4d4, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1017_b4d7, 2); or(al, 0x80);                           /* or al, 0x80 */
            ii(0x1017_b4d9, 5); mov(edx, 0x3d5);                        /* mov edx, 0x3d5 */
            ii(0x1017_b4de, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_b4e3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_b4e4, 2); shr(ebx, 0x1);                          /* shr ebx, 1 */
        l_0x1017_b4e6:
            ii(0x1017_b4e6, 10); mov(memd[ss, ebp - 0x120], /* sys */ 0x1018_cda8); /* mov dword [ebp-0x120], 0x1018cda8 */
            ii(0x1017_b4f0, 7); test(memb[ss, ebp - 0x12c], 0x2);       /* test byte [ebp-0x12c], 0x2 */
            ii(0x1017_b4f7, 2); if(jz(0x1017_b510, 0x17)) goto l_0x1017_b510; /* jz 0x1017b510 */
            ii(0x1017_b4f9, 6); mov(ah, memb[ss, ebp - 0x113]);         /* mov ah, [ebp-0x113] */
            ii(0x1017_b4ff, 3); cmp(ah, 0xf);                           /* cmp ah, 0xf */
            ii(0x1017_b502, 2); if(jz(0x1017_b509, 0x5)) goto l_0x1017_b509; /* jz 0x1017b509 */
            ii(0x1017_b504, 3); cmp(ah, 0x10);                          /* cmp ah, 0x10 */
            ii(0x1017_b507, 2); if(jnz(0x1017_b510, 0x7)) goto l_0x1017_b510; /* jnz 0x1017b510 */
        l_0x1017_b509:
            ii(0x1017_b509, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b50e, 2); jmp(0x1017_b512, 0x2); goto l_0x1017_b512; /* jmp 0x1017b512 */
        l_0x1017_b510:
            ii(0x1017_b510, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_b512:
            ii(0x1017_b512, 1); push(eax);                              /* push eax */
            ii(0x1017_b513, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b515, 6); mov(edx, memd[ss, ebp - 0x120]);        /* mov edx, [ebp-0x120] */
            ii(0x1017_b51b, 7); mov(ax, memw[ss, ebp - 0x128]);         /* mov ax, [ebp-0x128] */
            ii(0x1017_b522, 1); push(edx);                              /* push edx */
            ii(0x1017_b523, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x1017_b526, 1); push(eax);                              /* push eax */
            ii(0x1017_b527, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b529, 7); mov(ax, memw[ss, ebp - 0x126]);         /* mov ax, [ebp-0x126] */
            ii(0x1017_b530, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x1017_b533, 1); push(eax);                              /* push eax */
            ii(0x1017_b534, 1); push(edi);                              /* push edi */
            ii(0x1017_b535, 3); mov(esi, memd[ss, ebp - 0x18]);         /* mov esi, [ebp-0x18] */
            ii(0x1017_b538, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b53a, 1); push(esi);                              /* push esi */
            ii(0x1017_b53b, 7); mov(ax, memw[ss, ebp - 0x11c]);         /* mov ax, [ebp-0x11c] */
            ii(0x1017_b542, 1); push(eax);                              /* push eax */
            ii(0x1017_b543, 1); push(ebx);                              /* push ebx */
            ii(0x1017_b544, 1); push(ecx);                              /* push ecx */
            ii(0x1017_b545, 5); call(/* sys */ 0x1017_a620, -0xf2a);    /* call 0x1017a620 */
            ii(0x1017_b54a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b54f, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1017_b552, 3); lea(esp, memd[ss, ebp - 0x14]);         /* lea esp, [ebp-0x14] */
            ii(0x1017_b555, 1); pop(edi);                               /* pop edi */
            ii(0x1017_b556, 1); pop(esi);                               /* pop esi */
            ii(0x1017_b557, 1); pop(edx);                               /* pop edx */
            ii(0x1017_b558, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_b559, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_b55a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_b55b, 1); ret(); return;                          /* ret */
        l_0x1017_b55c:
            ii(0x1017_b55c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b55e, 3); lea(esp, memd[ss, ebp - 0x14]);         /* lea esp, [ebp-0x14] */
            ii(0x1017_b561, 1); pop(edi);                               /* pop edi */
            ii(0x1017_b562, 1); pop(esi);                               /* pop esi */
            ii(0x1017_b563, 1); pop(edx);                               /* pop edx */
            ii(0x1017_b564, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_b565, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_b566, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_b567, 1); ret();                                  /* ret */
        }
    }
}
