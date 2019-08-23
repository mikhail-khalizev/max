using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_abad-11e4427a")]
        public void /* sys */ Method_1019_abad()
        {
            ii(0x1019_abad, 1); push(ebx);                              /* push ebx */
            ii(0x1019_abae, 1); push(ecx);                              /* push ecx */
            ii(0x1019_abaf, 1); push(esi);                              /* push esi */
            ii(0x1019_abb0, 1); push(edi);                              /* push edi */
            ii(0x1019_abb1, 1); push(ebp);                              /* push ebp */
            ii(0x1019_abb2, 3); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1019_abb5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_abb7, 3); mov(ecx, memd[ds, eax + 0x20]);         /* mov ecx, [eax+0x20] */
            ii(0x1019_abba, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_abbc, 6); if(jnz(0x1019_ac7a, 0xb8)) goto l_0x1019_ac7a; /* jnz 0x1019ac7a */
            ii(0x1019_abc2, 6); lea(eax, edx + 0x76c);                  /* lea eax, [edx+0x76c] */
            ii(0x1019_abc8, 5); call(/* sys */ 0x1019_ab72, -0x5b);     /* call 0x1019ab72 */
            ii(0x1019_abcd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_abcf, 2); if(jz(0x1019_abe4, 0x13)) goto l_0x1019_abe4; /* jz 0x1019abe4 */
            ii(0x1019_abd1, 3); mov(eax, memd[ds, ebx + 0x10]);         /* mov eax, [ebx+0x10] */
            ii(0x1019_abd4, 7); mov(esi, memd[ds, eax * 2 + 0x101b_76e6]); /* mov esi, [eax*2+0x101b76e6] */
            ii(0x1019_abdb, 7); mov(eax, memd[ds, eax * 2 + 0x101b_76e4]); /* mov eax, [eax*2+0x101b76e4] */
            ii(0x1019_abe2, 2); jmp(0x1019_abf5, 0x11); goto l_0x1019_abf5; /* jmp 0x1019abf5 */
        l_0x1019_abe4:
            ii(0x1019_abe4, 3); mov(eax, memd[ds, ebx + 0x10]);         /* mov eax, [ebx+0x10] */
            ii(0x1019_abe7, 7); mov(esi, memd[ds, eax * 2 + 0x101b_76cc]); /* mov esi, [eax*2+0x101b76cc] */
            ii(0x1019_abee, 7); mov(eax, memd[ds, eax * 2 + 0x101b_76ca]); /* mov eax, [eax*2+0x101b76ca] */
        l_0x1019_abf5:
            ii(0x1019_abf5, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1019_abf8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1019_abfb, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1019_abfd, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1019_abff, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1019_ac04, 3); mov(memd[ss, esp], edi);                /* mov [esp], edi */
            ii(0x1019_ac07, 4); mov(memd[ss, esp + 0x4], edi);          /* mov [esp+0x4], edi */
            ii(0x1019_ac0b, 4); mov(memd[ss, esp + 0x8], edi);          /* mov [esp+0x8], edi */
            ii(0x1019_ac0f, 4); mov(memd[ss, esp + 0xc], ecx);          /* mov [esp+0xc], ecx */
            ii(0x1019_ac13, 3); mov(eax, memd[ds, ebx + 0x10]);         /* mov eax, [ebx+0x10] */
            ii(0x1019_ac16, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1019_ac1a, 4); mov(memd[ss, esp + 0x14], edx);         /* mov [esp+0x14], edx */
            ii(0x1019_ac1e, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1019_ac20, 4); mov(memd[ss, esp + 0x20], edi);         /* mov [esp+0x20], edi */
            ii(0x1019_ac24, 5); call(/* sys */ 0x1018_d888, -0xd3a1);   /* call 0x1018d888 */
            ii(0x1019_ac29, 4); mov(ebp, memd[ss, esp + 0x18]);         /* mov ebp, [esp+0x18] */
            ii(0x1019_ac2d, 3); mov(edx, memd[ds, ebx + 0x18]);         /* mov edx, [ebx+0x18] */
            ii(0x1019_ac30, 2); sub(edx, ebp);                          /* sub edx, ebp */
            ii(0x1019_ac32, 3); add(edx, 0x7);                          /* add edx, 0x7 */
            ii(0x1019_ac35, 5); mov(ecx, 0x7);                          /* mov ecx, 0x7 */
            ii(0x1019_ac3a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_ac3c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_ac3f, 2); idiv(ecx);                              /* idiv ecx */
            ii(0x1019_ac41, 3); mov(eax, memd[ds, ebx + 0xc]);          /* mov eax, [ebx+0xc] */
            ii(0x1019_ac44, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1019_ac47, 2); if(jnz(0x1019_ac68, 0x1f)) goto l_0x1019_ac68; /* jnz 0x1019ac68 */
            ii(0x1019_ac49, 3); lea(ecx, eax - 0x1);                    /* lea ecx, [eax-0x1] */
            ii(0x1019_ac4c, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1019_ac4e, 3); shl(edi, 0x3);                          /* shl edi, 0x3 */
            ii(0x1019_ac51, 3); lea(eax, edx + 0x1);                    /* lea eax, [edx+0x1] */
            ii(0x1019_ac54, 2); sub(edi, ecx);                          /* sub edi, ecx */
            ii(0x1019_ac56, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1019_ac58, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1019_ac5a, 2); if(jle(0x1019_ac64, 0x8)) goto l_0x1019_ac64; /* jle 0x1019ac64 */
            ii(0x1019_ac5c, 3); mov(eax, memd[ds, ebx + 0xc]);          /* mov eax, [ebx+0xc] */
            ii(0x1019_ac5f, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1019_ac62, 2); jmp(0x1019_ac69, 0x5); goto l_0x1019_ac69; /* jmp 0x1019ac69 */
        l_0x1019_ac64:
            ii(0x1019_ac64, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_ac66, 2); jmp(0x1019_ac69, 0x1); goto l_0x1019_ac69; /* jmp 0x1019ac69 */
        l_0x1019_ac68:
            ii(0x1019_ac68, 1); dec(eax);                               /* dec eax */
        l_0x1019_ac69:
            ii(0x1019_ac69, 4); mov(ebx, memd[ss, esp + 0x1c]);         /* mov ebx, [esp+0x1c] */
            ii(0x1019_ac6d, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1019_ac6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_ac71, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_ac74, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_ac76, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1019_ac78, 2); jmp(0x1019_ac89, 0xf); goto l_0x1019_ac89; /* jmp 0x1019ac89 */
        l_0x1019_ac7a:
            ii(0x1019_ac7a, 3); cmp(ecx, 0x1);                          /* cmp ecx, 0x1 */
            ii(0x1019_ac7d, 2); if(jnz(0x1019_ac86, 0x7)) goto l_0x1019_ac86; /* jnz 0x1019ac86 */
            ii(0x1019_ac7f, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x1019_ac82, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1019_ac84, 2); jmp(0x1019_ac89, 0x3); goto l_0x1019_ac89; /* jmp 0x1019ac89 */
        l_0x1019_ac86:
            ii(0x1019_ac86, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
        l_0x1019_ac89:
            ii(0x1019_ac89, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1019_ac8c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_ac8d, 1); pop(edi);                               /* pop edi */
            ii(0x1019_ac8e, 1); pop(esi);                               /* pop esi */
            ii(0x1019_ac8f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_ac90, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_ac91, 1); ret();                                  /* ret */
        }
    }
}
