using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5dd0-912fd3f1")]
        public void /* sys */ Method_1018_5dd0()
        {
            ii(0x1018_5dd0, 1); push(ebx);                              /* push ebx */
            ii(0x1018_5dd1, 1); push(esi);                              /* push esi */
            ii(0x1018_5dd2, 1); push(edi);                              /* push edi */
            ii(0x1018_5dd3, 3); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1018_5dd6, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_5dd8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_5dda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_5ddc, 4); lea(ebx, memd[ss, esp + 0x40]);         /* lea ebx, [esp+0x40] */
            ii(0x1018_5de0, 4); mov(memd[ss, esp + 0x50], edx);         /* mov [esp+0x50], edx */
            ii(0x1018_5de4, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_5de6, 5); call(/* sys */ 0x1018_5f8c, 0x1a1);     /* call 0x10185f8c */
            ii(0x1018_5deb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_5ded, 6); if(jnz(0x1018_5eb0, 0xbd)) goto l_0x1018_5eb0; /* jnz 0x10185eb0 */
            ii(0x1018_5df3, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1018_5df5, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1018_5df8, 3); mov(eax, memd[ds, esi + 0x4]);          /* mov eax, [esi+0x4] */
            ii(0x1018_5dfb, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1018_5dff, 3); mov(eax, memd[ds, esi + 0x8]);          /* mov eax, [esi+0x8] */
            ii(0x1018_5e02, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1018_5e06, 4); mov(eax, memd[ss, esp + 0x44]);         /* mov eax, [esp+0x44] */
            ii(0x1018_5e0a, 1); dec(eax);                               /* dec eax */
            ii(0x1018_5e0b, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1018_5e0f, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1018_5e11, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1018_5e15, 4); mov(eax, memd[ss, esp + 0x44]);         /* mov eax, [esp+0x44] */
            ii(0x1018_5e19, 4); mov(memd[ss, esp + 0x14], eax);         /* mov [esp+0x14], eax */
            ii(0x1018_5e1d, 4); mov(eax, memd[ss, esp + 0x40]);         /* mov eax, [esp+0x40] */
            ii(0x1018_5e21, 1); dec(eax);                               /* dec eax */
            ii(0x1018_5e22, 4); mov(memd[ss, esp + 0x18], eax);         /* mov [esp+0x18], eax */
            ii(0x1018_5e26, 4); mov(eax, memd[ss, esp + 0x4c]);         /* mov eax, [esp+0x4c] */
            ii(0x1018_5e2a, 4); mov(memd[ss, esp + 0x1c], eax);         /* mov [esp+0x1c], eax */
            ii(0x1018_5e2e, 4); mov(eax, memd[ss, esp + 0x48]);         /* mov eax, [esp+0x48] */
            ii(0x1018_5e32, 1); inc(eax);                               /* inc eax */
            ii(0x1018_5e33, 4); mov(memd[ss, esp + 0x20], eax);         /* mov [esp+0x20], eax */
            ii(0x1018_5e37, 4); mov(eax, memd[ss, esp + 0x44]);         /* mov eax, [esp+0x44] */
            ii(0x1018_5e3b, 4); mov(memd[ss, esp + 0x24], eax);         /* mov [esp+0x24], eax */
            ii(0x1018_5e3f, 3); mov(eax, memd[ds, esi + 0x8]);          /* mov eax, [esi+0x8] */
            ii(0x1018_5e42, 4); mov(memd[ss, esp + 0x28], eax);         /* mov [esp+0x28], eax */
            ii(0x1018_5e46, 4); mov(eax, memd[ss, esp + 0x4c]);         /* mov eax, [esp+0x4c] */
            ii(0x1018_5e4a, 4); mov(memd[ss, esp + 0x2c], eax);         /* mov [esp+0x2c], eax */
            ii(0x1018_5e4e, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1018_5e50, 4); mov(memd[ss, esp + 0x30], eax);         /* mov [esp+0x30], eax */
            ii(0x1018_5e54, 4); mov(eax, memd[ss, esp + 0x4c]);         /* mov eax, [esp+0x4c] */
            ii(0x1018_5e58, 1); inc(eax);                               /* inc eax */
            ii(0x1018_5e59, 4); mov(memd[ss, esp + 0x34], eax);         /* mov [esp+0x34], eax */
            ii(0x1018_5e5d, 3); mov(eax, memd[ds, esi + 0x8]);          /* mov eax, [esi+0x8] */
            ii(0x1018_5e60, 4); mov(memd[ss, esp + 0x38], eax);         /* mov [esp+0x38], eax */
            ii(0x1018_5e64, 4); lea(ebx, memd[ss, esp + 0x50]);         /* lea ebx, [esp+0x50] */
            ii(0x1018_5e68, 3); mov(eax, memd[ds, esi + 0xc]);          /* mov eax, [esi+0xc] */
            ii(0x1018_5e6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_5e6d, 4); mov(memd[ss, esp + 0x3c], eax);         /* mov [esp+0x3c], eax */
        l_0x1018_5e71:
            ii(0x1018_5e71, 3); mov(eax, memd[ss, esp + edx]);          /* mov eax, [esp+edx] */
            ii(0x1018_5e74, 4); cmp(eax, memd[ss, esp + edx + 0x8]);    /* cmp eax, [esp+edx+0x8] */
            ii(0x1018_5e78, 2); if(jg(0x1018_5ea6, 0x2c)) goto l_0x1018_5ea6; /* jg 0x10185ea6 */
            ii(0x1018_5e7a, 4); mov(eax, memd[ss, esp + edx + 0x4]);    /* mov eax, [esp+edx+0x4] */
            ii(0x1018_5e7e, 4); cmp(eax, memd[ss, esp + edx + 0xc]);    /* cmp eax, [esp+edx+0xc] */
            ii(0x1018_5e82, 2); if(jg(0x1018_5ea6, 0x22)) goto l_0x1018_5ea6; /* jg 0x10185ea6 */
            ii(0x1018_5e84, 5); call(/* sys */ 0x1018_5edc, 0x53);      /* call 0x10185edc */
            ii(0x1018_5e89, 2); mov(memd[ds, ebx], eax);                /* mov [ebx], eax */
            ii(0x1018_5e8b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_5e8d, 2); if(jz(0x1018_5ed2, 0x43)) goto l_0x1018_5ed2; /* jz 0x10185ed2 */
            ii(0x1018_5e8f, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_5e91, 3); lea(esi, memd[ss, esp + edx]);          /* lea esi, [esp+edx] */
            ii(0x1018_5e94, 1); movsd();                                /* movsd */
            ii(0x1018_5e95, 1); movsd();                                /* movsd */
            ii(0x1018_5e96, 1); movsd();                                /* movsd */
            ii(0x1018_5e97, 1); movsd();                                /* movsd */
            ii(0x1018_5e98, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1018_5e9a, 7); mov(memd[ds, eax + 0x10], 0);           /* mov dword [eax+0x10], 0x0 */
            ii(0x1018_5ea1, 2); mov(ebx, memd[ds, ebx]);                /* mov ebx, [ebx] */
            ii(0x1018_5ea3, 3); add(ebx, 0x10);                         /* add ebx, 0x10 */
        l_0x1018_5ea6:
            ii(0x1018_5ea6, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1018_5ea9, 3); cmp(edx, 0x40);                         /* cmp edx, 0x40 */
            ii(0x1018_5eac, 2); if(jl(0x1018_5e71, -0x3d)) goto l_0x1018_5e71; /* jl 0x10185e71 */
            ii(0x1018_5eae, 2); jmp(0x1018_5ece, 0x1e); goto l_0x1018_5ece; /* jmp 0x10185ece */
        l_0x1018_5eb0:
            ii(0x1018_5eb0, 5); call(/* sys */ 0x1018_5edc, 0x27);      /* call 0x10185edc */
            ii(0x1018_5eb5, 4); mov(memd[ss, esp + 0x50], eax);         /* mov [esp+0x50], eax */
            ii(0x1018_5eb9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_5ebb, 2); if(jz(0x1018_5ece, 0x11)) goto l_0x1018_5ece; /* jz 0x10185ece */
            ii(0x1018_5ebd, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_5ebf, 1); movsd();                                /* movsd */
            ii(0x1018_5ec0, 1); movsd();                                /* movsd */
            ii(0x1018_5ec1, 1); movsd();                                /* movsd */
            ii(0x1018_5ec2, 1); movsd();                                /* movsd */
            ii(0x1018_5ec3, 4); mov(eax, memd[ss, esp + 0x50]);         /* mov eax, [esp+0x50] */
            ii(0x1018_5ec7, 7); mov(memd[ds, eax + 0x10], 0);           /* mov dword [eax+0x10], 0x0 */
        l_0x1018_5ece:
            ii(0x1018_5ece, 4); mov(eax, memd[ss, esp + 0x50]);         /* mov eax, [esp+0x50] */
        l_0x1018_5ed2:
            ii(0x1018_5ed2, 3); add(esp, 0x54);                         /* add esp, 0x54 */
            ii(0x1018_5ed5, 1); pop(edi);                               /* pop edi */
            ii(0x1018_5ed6, 1); pop(esi);                               /* pop esi */
            ii(0x1018_5ed7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_5ed8, 1); ret();                                  /* ret */
        }
    }
}
