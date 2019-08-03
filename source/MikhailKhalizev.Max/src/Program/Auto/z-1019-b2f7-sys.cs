using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aef752d7-acfa-4125-bbdf-065285569e41")]
        public void /* sys */ Method_1019_b2f7()
        {
            ii(0x1019_b2f7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_b2f8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_b2f9, 1); pushd(esi);                             /* push esi */
            ii(0x1019_b2fa, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1019_b2fd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b2ff, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_b301, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b303, 2); mov(al, memb_a32[ds, ebx]);             /* mov al, [ebx] */
            ii(0x1019_b305, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1019_b30a, 3); cmp(eax, 0x4a);                         /* cmp eax, 0x4a */
            ii(0x1019_b30d, 2); if(jnzd(0x1019_b316, 0x7)) goto l_0x1019_b316; /* jnz 0x1019b316 */
            ii(0x1019_b30f, 5); mov(esi, 0x1);                          /* mov esi, 0x1 */
            ii(0x1019_b314, 2); add(ebx, esi);                          /* add ebx, esi */
        l_0x1019_b316:
            ii(0x1019_b316, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b318, 2); mov(al, memb_a32[ds, ebx]);             /* mov al, [ebx] */
            ii(0x1019_b31a, 3); cmp(eax, 0x4d);                         /* cmp eax, 0x4d */
            ii(0x1019_b31d, 2); if(jnzd(0x1019_b322, 0x3)) goto l_0x1019_b322; /* jnz 0x1019b322 */
            ii(0x1019_b31f, 1); inc(ebx);                               /* inc ebx */
            ii(0x1019_b320, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1019_b322:
            ii(0x1019_b322, 4); lea(edx, esp + 0xc);                    /* lea edx, [esp+0xc] */
            ii(0x1019_b326, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b328, 3); mov(memd_a32[ds, ecx + 0x20], esi);     /* mov [ecx+0x20], esi */
            ii(0x1019_b32b, 5); calld(/* sys */ 0x1019_b1aa, -0x186);   /* call 0x1019b1aa */
            ii(0x1019_b330, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b332, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b334, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_b336, 2); if(jzd(0x1019_b341, 0x9)) goto l_0x1019_b341; /* jz 0x1019b341 */
            ii(0x1019_b338, 4); mov(eax, memd_a32[ss, esp + 0xc]);      /* mov eax, [esp+0xc] */
            ii(0x1019_b33c, 3); mov(memd_a32[ds, ecx + 0x1c], eax);     /* mov [ecx+0x1c], eax */
            ii(0x1019_b33f, 2); jmpd(0x1019_b38e, 0x4d); goto l_0x1019_b38e; /* jmp 0x1019b38e */
        l_0x1019_b341:
            ii(0x1019_b341, 4); mov(eax, memd_a32[ss, esp + 0xc]);      /* mov eax, [esp+0xc] */
            ii(0x1019_b345, 1); dec(eax);                               /* dec eax */
            ii(0x1019_b346, 3); mov(memd_a32[ds, ecx + 0x10], eax);     /* mov [ecx+0x10], eax */
            ii(0x1019_b349, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b34b, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1019_b34d, 3); cmp(eax, 0x2e);                         /* cmp eax, 0x2e */
            ii(0x1019_b350, 2); if(jnzd(0x1019_b387, 0x35)) goto l_0x1019_b387; /* jnz 0x1019b387 */
            ii(0x1019_b352, 3); lea(eax, edx + 0x1);                    /* lea eax, [edx+0x1] */
            ii(0x1019_b355, 4); lea(edx, esp + 0xc);                    /* lea edx, [esp+0xc] */
            ii(0x1019_b359, 5); calld(/* sys */ 0x1019_b1aa, -0x1b4);   /* call 0x1019b1aa */
            ii(0x1019_b35e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b360, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b362, 4); mov(eax, memd_a32[ss, esp + 0xc]);      /* mov eax, [esp+0xc] */
            ii(0x1019_b366, 3); mov(memd_a32[ds, ecx + 0xc], eax);      /* mov [ecx+0xc], eax */
            ii(0x1019_b369, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b36b, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1019_b36d, 3); cmp(eax, 0x2e);                         /* cmp eax, 0x2e */
            ii(0x1019_b370, 2); if(jnzd(0x1019_b387, 0x15)) goto l_0x1019_b387; /* jnz 0x1019b387 */
            ii(0x1019_b372, 3); lea(eax, edx + 0x1);                    /* lea eax, [edx+0x1] */
            ii(0x1019_b375, 4); lea(edx, esp + 0xc);                    /* lea edx, [esp+0xc] */
            ii(0x1019_b379, 5); calld(/* sys */ 0x1019_b1aa, -0x1d4);   /* call 0x1019b1aa */
            ii(0x1019_b37e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b380, 4); mov(eax, memd_a32[ss, esp + 0xc]);      /* mov eax, [esp+0xc] */
            ii(0x1019_b384, 3); mov(memd_a32[ds, ecx + 0x18], eax);     /* mov [ecx+0x18], eax */
        l_0x1019_b387:
            ii(0x1019_b387, 7); mov(memd_a32[ds, ecx + 0x1c], 0);       /* mov dword [ecx+0x1c], 0x0 */
        l_0x1019_b38e:
            ii(0x1019_b38e, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1019_b393, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1019_b395, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b397, 4); mov(memd_a32[ss, esp + 0x8], edx);      /* mov [esp+0x8], edx */
            ii(0x1019_b39b, 3); mov(memd_a32[ss, esp], esi);            /* mov [esp], esi */
            ii(0x1019_b39e, 4); mov(memd_a32[ss, esp + 0x4], esi);      /* mov [esp+0x4], esi */
            ii(0x1019_b3a2, 2); mov(al, memb_a32[ds, ebx]);             /* mov al, [ebx] */
            ii(0x1019_b3a4, 3); cmp(eax, 0x2f);                         /* cmp eax, 0x2f */
            ii(0x1019_b3a7, 2); if(jnzd(0x1019_b3df, 0x36)) goto l_0x1019_b3df; /* jnz 0x1019b3df */
            ii(0x1019_b3a9, 4); lea(edx, esp + 0x8);                    /* lea edx, [esp+0x8] */
            ii(0x1019_b3ad, 3); lea(eax, ebx + 0x1);                    /* lea eax, [ebx+0x1] */
            ii(0x1019_b3b0, 5); calld(/* sys */ 0x1019_b1aa, -0x20b);   /* call 0x1019b1aa */
            ii(0x1019_b3b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b3b7, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1019_b3b9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b3bb, 3); cmp(edx, 0x3a);                         /* cmp edx, 0x3a */
            ii(0x1019_b3be, 2); if(jnzd(0x1019_b3df, 0x1f)) goto l_0x1019_b3df; /* jnz 0x1019b3df */
            ii(0x1019_b3c0, 4); lea(edx, esp + 0x4);                    /* lea edx, [esp+0x4] */
            ii(0x1019_b3c4, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b3c5, 5); calld(/* sys */ 0x1019_b1aa, -0x220);   /* call 0x1019b1aa */
            ii(0x1019_b3ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b3cc, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1019_b3ce, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b3d0, 3); cmp(edx, 0x3a);                         /* cmp edx, 0x3a */
            ii(0x1019_b3d3, 2); if(jnzd(0x1019_b3df, 0xa)) goto l_0x1019_b3df; /* jnz 0x1019b3df */
            ii(0x1019_b3d5, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1019_b3d7, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b3d8, 5); calld(/* sys */ 0x1019_b1aa, -0x233);   /* call 0x1019b1aa */
            ii(0x1019_b3dd, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1019_b3df:
            ii(0x1019_b3df, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1019_b3e2, 2); mov(memd_a32[ds, ecx], eax);            /* mov [ecx], eax */
            ii(0x1019_b3e4, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1019_b3e8, 3); mov(memd_a32[ds, ecx + 0x4], eax);      /* mov [ecx+0x4], eax */
            ii(0x1019_b3eb, 4); mov(eax, memd_a32[ss, esp + 0x8]);      /* mov eax, [esp+0x8] */
            ii(0x1019_b3ef, 3); mov(memd_a32[ds, ecx + 0x8], eax);      /* mov [ecx+0x8], eax */
            ii(0x1019_b3f2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b3f4, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1019_b3f7, 1); popd(esi);                              /* pop esi */
            ii(0x1019_b3f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_b3f9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_b3fa, 1); retd(); return;                         /* ret */
        }
    }
}
