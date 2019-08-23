using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_8624-8b83f7bb")]
        public void /* sys */ Method_1016_8624()
        {
            ii(0x1016_8624, 1); push(ebx);                              /* push ebx */
            ii(0x1016_8625, 1); push(ecx);                              /* push ecx */
            ii(0x1016_8626, 1); push(esi);                              /* push esi */
            ii(0x1016_8627, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_862a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_862c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_862e, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1016_8633, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_8635, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_8637, 5); call(Definitions.sys_memset, -0x285c);  /* call 0x10165de0 */
            ii(0x1016_863c, 3); test(cl, 0x1);                          /* test cl, 0x1 */
            ii(0x1016_863f, 2); if(jz(0x1016_8647, 0x6)) goto l_0x1016_8647; /* jz 0x10168647 */
            ii(0x1016_8641, 4); mov(memb[ss, esp], 0x77);               /* mov byte [esp], 0x77 */
            ii(0x1016_8645, 2); jmp(0x1016_8660, 0x19); goto l_0x1016_8660; /* jmp 0x10168660 */
        l_0x1016_8647:
            ii(0x1016_8647, 3); test(cl, 0x10);                         /* test cl, 0x10 */
            ii(0x1016_864a, 2); if(jz(0x1016_865c, 0x10)) goto l_0x1016_865c; /* jz 0x1016865c */
            ii(0x1016_864c, 4); mov(memb[ss, esp], 0x61);               /* mov byte [esp], 0x61 */
            ii(0x1016_8650, 3); test(ch, 0x1);                          /* test ch, 0x1 */
            ii(0x1016_8653, 2); if(jz(0x1016_866c, 0x17)) goto l_0x1016_866c; /* jz 0x1016866c */
            ii(0x1016_8655, 5); mov(memb[ss, esp + 0x1], 0x74);         /* mov byte [esp+0x1], 0x74 */
            ii(0x1016_865a, 2); jmp(0x1016_8676, 0x1a); goto l_0x1016_8676; /* jmp 0x10168676 */
        l_0x1016_865c:
            ii(0x1016_865c, 4); mov(memb[ss, esp], 0x72);               /* mov byte [esp], 0x72 */
        l_0x1016_8660:
            ii(0x1016_8660, 3); test(ch, 0x1);                          /* test ch, 0x1 */
            ii(0x1016_8663, 2); if(jz(0x1016_866c, 0x7)) goto l_0x1016_866c; /* jz 0x1016866c */
            ii(0x1016_8665, 5); mov(memb[ss, esp + 0x1], 0x74);         /* mov byte [esp+0x1], 0x74 */
            ii(0x1016_866a, 2); jmp(0x1016_8676, 0xa); goto l_0x1016_8676; /* jmp 0x10168676 */
        l_0x1016_866c:
            ii(0x1016_866c, 3); test(ch, 0x2);                          /* test ch, 0x2 */
            ii(0x1016_866f, 2); if(jz(0x1016_8676, 0x5)) goto l_0x1016_8676; /* jz 0x10168676 */
            ii(0x1016_8671, 5); mov(memb[ss, esp + 0x1], 0x62);         /* mov byte [esp+0x1], 0x62 */
        l_0x1016_8676:
            ii(0x1016_8676, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_8678, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_867a, 5); call(Definitions.sys_fopen_internal, 0x6145); /* call 0x1016e7c4 */
            ii(0x1016_867f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8681, 2); if(jnz(0x1016_8688, 0x5)) goto l_0x1016_8688; /* jnz 0x10168688 */
            ii(0x1016_8683, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_8688:
            ii(0x1016_8688, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_868b, 1); pop(esi);                               /* pop esi */
            ii(0x1016_868c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_868d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_868e, 1); ret();                                  /* ret */
        }
    }
}
