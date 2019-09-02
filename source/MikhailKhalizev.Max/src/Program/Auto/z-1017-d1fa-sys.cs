using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d1fa-b0687082")]
        public void /* sys */ Method_1017_d1fa()
        {
            ii(0x1017_d1fa, 1); push(ecx);                              /* push ecx */
            ii(0x1017_d1fb, 1); push(esi);                              /* push esi */
            ii(0x1017_d1fc, 1); push(edi);                              /* push edi */
            ii(0x1017_d1fd, 1); push(ebp);                              /* push ebp */
            ii(0x1017_d1fe, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1017_d201, 1); push(eax);                              /* push eax */
            ii(0x1017_d202, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1017_d204, 5); call(/* sys */ 0x1019_46a5, 0x1_749c);  /* call 0x101946a5 */
            ii(0x1017_d209, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1017_d20d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d20f, 2); if(jnz(0x1017_d225, 0x14)) goto l_0x1017_d225; /* jnz 0x1017d225 */
            ii(0x1017_d211, 5); mov(eax, 4);                            /* mov eax, 0x4 */
        l_0x1017_d216:
            ii(0x1017_d216, 5); call(/* sys */ 0x1018_d3bf, 0x1_01a4);  /* call 0x1018d3bf */
            ii(0x1017_d21b, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_d220, 5); jmp(0x1017_d2ed, 0xc8); goto l_0x1017_d2ed; /* jmp 0x1017d2ed */
        l_0x1017_d225:
            ii(0x1017_d225, 2); test(al, 1);                            /* test al, 0x1 */
            ii(0x1017_d227, 2); if(jnz(0x1017_d230, 7)) goto l_0x1017_d230; /* jnz 0x1017d230 */
            ii(0x1017_d229, 5); mov(eax, 6);                            /* mov eax, 0x6 */
            ii(0x1017_d22e, 2); jmp(0x1017_d216, -0x1a); goto l_0x1017_d216; /* jmp 0x1017d216 */
        l_0x1017_d230:
            ii(0x1017_d230, 2); test(al, 0x40);                         /* test al, 0x40 */
            ii(0x1017_d232, 2); if(jz(0x1017_d25c, 0x28)) goto l_0x1017_d25c; /* jz 0x1017d25c */
            ii(0x1017_d234, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1017_d236, 3); mov(ebx, memd[ss, esp]);                /* mov ebx, [esp] */
            ii(0x1017_d239, 2); mov(ah, 0x3f);                          /* mov ah, 0x3f */
            ii(0x1017_d23b, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d23d, 2); rcl(eax, 1);                            /* rcl eax, 1 */
            ii(0x1017_d23f, 2); ror(eax, 1);                            /* ror eax, 1 */
            ii(0x1017_d241, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_d243, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_d245, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d247, 6); if(jge(0x1017_d2eb, 0x9e)) goto l_0x1017_d2eb; /* jge 0x1017d2eb */
            ii(0x1017_d24d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d24f, 3); mov(ax, di);                            /* mov ax, di */
        l_0x1017_d252:
            ii(0x1017_d252, 5); call(/* sys */ 0x1018_dbb7, 0x1_0960);  /* call 0x1018dbb7 */
            ii(0x1017_d257, 5); jmp(0x1017_d2ed, 0x91); goto l_0x1017_d2ed; /* jmp 0x1017d2ed */
        l_0x1017_d25c:
            ii(0x1017_d25c, 4); mov(memd[ss, esp + 12], ebx);           /* mov [esp+0xc], ebx */
            ii(0x1017_d260, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1017_d262:
            ii(0x1017_d262, 4); mov(ecx, memd[ss, esp + 12]);           /* mov ecx, [esp+0xc] */
            ii(0x1017_d266, 3); mov(ebx, memd[ss, esp]);                /* mov ebx, [esp] */
            ii(0x1017_d269, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1017_d26b, 2); mov(ah, 0x3f);                          /* mov ah, 0x3f */
            ii(0x1017_d26d, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_d26f, 2); rcl(eax, 1);                            /* rcl eax, 1 */
            ii(0x1017_d271, 2); ror(eax, 1);                            /* ror eax, 1 */
            ii(0x1017_d273, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_d275, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_d277, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
            ii(0x1017_d27b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d27d, 2); if(jge(0x1017_d286, 7)) goto l_0x1017_d286; /* jge 0x1017d286 */
            ii(0x1017_d27f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d281, 3); mov(ax, bx);                            /* mov ax, bx */
            ii(0x1017_d284, 2); jmp(0x1017_d252, -0x34); goto l_0x1017_d252; /* jmp 0x1017d252 */
        l_0x1017_d286:
            ii(0x1017_d286, 2); if(jz(0x1017_d2eb, 0x63)) goto l_0x1017_d2eb; /* jz 0x1017d2eb */
            ii(0x1017_d288, 2); xor(edi, eax);                          /* xor edi, eax */
            ii(0x1017_d28a, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_d28c, 3); lea(ecx, memd[ds, ebx + ebp]);          /* lea ecx, [ebx+ebp] */
            ii(0x1017_d28f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d291, 4); mov(memd[ss, esp + 16], ecx);           /* mov [esp+0x10], ecx */
            ii(0x1017_d295, 2); jmp(0x1017_d2c8, 0x31); goto l_0x1017_d2c8; /* jmp 0x1017d2c8 */
        l_0x1017_d297:
            ii(0x1017_d297, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_d299, 2); mov(bl, memb[ds, eax]);                 /* mov bl, [eax] */
            ii(0x1017_d29b, 3); cmp(ebx, 0x1a);                         /* cmp ebx, 0x1a */
            ii(0x1017_d29e, 2); if(jnz(0x1017_d2b8, 0x18)) goto l_0x1017_d2b8; /* jnz 0x1017d2b8 */
            ii(0x1017_d2a0, 4); mov(ebp, memd[ss, esp + 4]);            /* mov ebp, [esp+0x4] */
            ii(0x1017_d2a4, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1017_d2a6, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1017_d2ab, 2); sub(edx, ebp);                          /* sub edx, ebp */
            ii(0x1017_d2ad, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1017_d2b0, 1); inc(edx);                               /* inc edx */
            ii(0x1017_d2b1, 5); call(Definitions.sys_lseek, -0x11f);    /* call 0x1017d197 */
            ii(0x1017_d2b6, 2); jmp(0x1017_d2eb, 0x33); goto l_0x1017_d2eb; /* jmp 0x1017d2eb */
        l_0x1017_d2b8:
            ii(0x1017_d2b8, 3); cmp(ebx, 0xd);                          /* cmp ebx, 0xd */
            ii(0x1017_d2bb, 2); if(jz(0x1017_d2c6, 9)) goto l_0x1017_d2c6; /* jz 0x1017d2c6 */
            ii(0x1017_d2bd, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_d2bf, 1); inc(esi);                               /* inc esi */
            ii(0x1017_d2c0, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1017_d2c2, 1); inc(edx);                               /* inc edx */
            ii(0x1017_d2c3, 3); mov(memb[ds, ebx + ebp], cl);           /* mov [ebx+ebp], cl */
        l_0x1017_d2c6:
            ii(0x1017_d2c6, 1); inc(eax);                               /* inc eax */
            ii(0x1017_d2c7, 1); inc(edi);                               /* inc edi */
        l_0x1017_d2c8:
            ii(0x1017_d2c8, 4); cmp(eax, memd[ss, esp + 16]);           /* cmp eax, [esp+0x10] */
            ii(0x1017_d2cc, 2); if(jb(0x1017_d297, -0x37)) goto l_0x1017_d297; /* jb 0x1017d297 */
            ii(0x1017_d2ce, 4); mov(ecx, memd[ss, esp + 12]);           /* mov ecx, [esp+0xc] */
            ii(0x1017_d2d2, 4); mov(ah, memb[ss, esp + 9]);             /* mov ah, [esp+0x9] */
            ii(0x1017_d2d6, 2); sub(ecx, edx);                          /* sub ecx, edx */
            ii(0x1017_d2d8, 2); add(ebp, edx);                          /* add ebp, edx */
            ii(0x1017_d2da, 4); mov(memd[ss, esp + 12], ecx);           /* mov [esp+0xc], ecx */
            ii(0x1017_d2de, 3); test(ah, 0x20);                         /* test ah, 0x20 */
            ii(0x1017_d2e1, 2); if(jnz(0x1017_d2eb, 8)) goto l_0x1017_d2eb; /* jnz 0x1017d2eb */
            ii(0x1017_d2e3, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_d2e5, 6); if(jnz(0x1017_d262, -0x89)) goto l_0x1017_d262; /* jnz 0x1017d262 */
        l_0x1017_d2eb:
            ii(0x1017_d2eb, 2); mov(eax, esi);                          /* mov eax, esi */
        l_0x1017_d2ed:
            ii(0x1017_d2ed, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1017_d2f0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_d2f1, 1); pop(edi);                               /* pop edi */
            ii(0x1017_d2f2, 1); pop(esi);                               /* pop esi */
            ii(0x1017_d2f3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_d2f4, 1); ret();                                  /* ret */
        }
    }
}
