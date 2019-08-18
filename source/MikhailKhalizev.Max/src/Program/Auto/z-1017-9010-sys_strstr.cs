using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4dad7f8a-221a-4ac6-b7b5-d072f4d0f48d")]
        public void /* sys */ sys_strstr()
        {
            ii(0x1017_9010, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_9011, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_9012, 1); pushd(esi);                             /* push esi */
            ii(0x1017_9013, 1); pushd(edi);                             /* push edi */
            ii(0x1017_9014, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_9015, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_9018, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_901a, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_901c, 3); cmp(memb_a32[ds, edx], 0);              /* cmp byte [edx], 0x0 */
            ii(0x1017_901f, 2); if(jnzd(0x1017_9028, 0x7)) goto l_0x1017_9028; /* jnz 0x10179028 */
        l_0x1017_9021:
            ii(0x1017_9021, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_9023, 5); if(jmpd_func(0x1017_90c5, 0x9d)) return; /* jmp 0x101790c5 */
        l_0x1017_9028:
            ii(0x1017_9028, 4); cmp(memb_a32[ds, edx + 0x1], 0);        /* cmp byte [edx+0x1], 0x0 */
            ii(0x1017_902c, 2); if(jnzd(0x1017_904a, 0x1c)) goto l_0x1017_904a; /* jnz 0x1017904a */
            ii(0x1017_902e, 2); mov(dl, memb_a32[ds, ebx]);             /* mov dl, [ebx] */
        l_0x1017_9030:
            ii(0x1017_9030, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_9032, 2); cmp(al, dl);                            /* cmp al, dl */
            ii(0x1017_9034, 2); if(jzd(0x1017_9048, 0x12)) goto l_0x1017_9048; /* jz 0x10179048 */
            ii(0x1017_9036, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_9038, 2); if(jzd(0x1017_9046, 0xc)) goto l_0x1017_9046; /* jz 0x10179046 */
            ii(0x1017_903a, 1); inc(esi);                               /* inc esi */
            ii(0x1017_903b, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_903d, 2); cmp(al, dl);                            /* cmp al, dl */
            ii(0x1017_903f, 2); if(jzd(0x1017_9048, 0x7)) goto l_0x1017_9048; /* jz 0x10179048 */
            ii(0x1017_9041, 1); inc(esi);                               /* inc esi */
            ii(0x1017_9042, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_9044, 2); if(jnzd(0x1017_9030, -0x16)) goto l_0x1017_9030; /* jnz 0x10179030 */
        l_0x1017_9046:
            ii(0x1017_9046, 2); sub(esi, esi);                          /* sub esi, esi */
        l_0x1017_9048:
            ii(0x1017_9048, 2); jmpd(0x1017_9021, -0x29); goto l_0x1017_9021; /* jmp 0x10179021 */
        l_0x1017_904a:
            ii(0x1017_904a, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_904f, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_9051, 2); xor(al, al);                            /* xor al, al */
            ii(0x1017_9053, 1); pushd(es);                              /* push es */
            ii(0x1017_9054, 2); if(jecxzd_func(0x1017_9061, 0xb)) return; /* jecxz 0x10179061 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1017_9056, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9058, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1017_905a, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_905c, 2); if(jnzd_func(0x1017_9061, 0x3)) return; /* jnz 0x10179061 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x1017_905e, 1); dec(edi);                               /* dec edi */
            ii(0x1017_905f, 4); test(ax, 0xcf89);                       /* test ax, 0xcf89 */
            ii(0x1017_9063, 1); popd(es);                               /* pop es */
            ii(0x1017_9064, 3); mov(memd_a32[ss, esp], edi);            /* mov [esp], edi */
            ii(0x1017_9067, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1017_9069, 1); pushd(es);                              /* push es */
            ii(0x1017_906a, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_906c, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_906e, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1017_9070, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_9071, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9073, 2); repne_a32(() => scasb_a32());           /* repne scasb */
            ii(0x1017_9075, 2); not(ecx);                               /* not ecx */
            ii(0x1017_9077, 1); dec(ecx);                               /* dec ecx */
            ii(0x1017_9078, 1); popd(es);                               /* pop es */
            ii(0x1017_9079, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
        }
    }
}
