using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9010-5f42e0b3")]
        public void /* sys */ sys_strstr()
        {
            ii(0x1017_9010, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9011, 1); push(ecx);                              /* push ecx */
            ii(0x1017_9012, 1); push(esi);                              /* push esi */
            ii(0x1017_9013, 1); push(edi);                              /* push edi */
            ii(0x1017_9014, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9015, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1017_9018, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_901a, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_901c, 3); cmp(memb[ds, edx], 0);                  /* cmp byte [edx], 0x0 */
            ii(0x1017_901f, 2); if(jnz(0x1017_9028, 7)) goto l_0x1017_9028; /* jnz 0x10179028 */
        l_0x1017_9021:
            ii(0x1017_9021, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_9023, 5); if(jmp_func(0x1017_90c5, 0x9d)) return; /* jmp 0x101790c5 */
        l_0x1017_9028:
            ii(0x1017_9028, 4); cmp(memb[ds, edx + 1], 0);              /* cmp byte [edx+0x1], 0x0 */
            ii(0x1017_902c, 2); if(jnz(0x1017_904a, 0x1c)) goto l_0x1017_904a; /* jnz 0x1017904a */
            ii(0x1017_902e, 2); mov(dl, memb[ds, ebx]);                 /* mov dl, [ebx] */
        l_0x1017_9030:
            ii(0x1017_9030, 2); mov(al, memb[ds, esi]);                 /* mov al, [esi] */
            ii(0x1017_9032, 2); cmp(al, dl);                            /* cmp al, dl */
            ii(0x1017_9034, 2); if(jz(0x1017_9048, 0x12)) goto l_0x1017_9048; /* jz 0x10179048 */
            ii(0x1017_9036, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_9038, 2); if(jz(0x1017_9046, 0xc)) goto l_0x1017_9046; /* jz 0x10179046 */
            ii(0x1017_903a, 1); inc(esi);                               /* inc esi */
            ii(0x1017_903b, 2); mov(al, memb[ds, esi]);                 /* mov al, [esi] */
            ii(0x1017_903d, 2); cmp(al, dl);                            /* cmp al, dl */
            ii(0x1017_903f, 2); if(jz(0x1017_9048, 7)) goto l_0x1017_9048; /* jz 0x10179048 */
            ii(0x1017_9041, 1); inc(esi);                               /* inc esi */
            ii(0x1017_9042, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1017_9044, 2); if(jnz(0x1017_9030, -0x16)) goto l_0x1017_9030; /* jnz 0x10179030 */
        l_0x1017_9046:
            ii(0x1017_9046, 2); sub(esi, esi);                          /* sub esi, esi */
        l_0x1017_9048:
            ii(0x1017_9048, 2); jmp(0x1017_9021, -0x29); goto l_0x1017_9021; /* jmp 0x10179021 */
        l_0x1017_904a:
            ii(0x1017_904a, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1017_904f, 2); mov(edi, esi);                          /* mov edi, esi */
            ii(0x1017_9051, 2); xor(al, al);                            /* xor al, al */
            ii(0x1017_9053, 1); pushd(es);                              /* push es */
            ii(0x1017_9054, 2); if(jecxz_func(0x1017_9061, 0xb)) return; /* jecxz 0x10179061 */
            ii(0x1017_9056, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_9058, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1017_905a, 2); repne(() => scasb());                   /* repne scasb */
            ii(0x1017_905c, 2); if(jnz_func(0x1017_9061, 3)) return;    /* jnz 0x10179061 */
            ii(0x1017_905e, 1); dec(edi);                               /* dec edi */
        }
    }
}
