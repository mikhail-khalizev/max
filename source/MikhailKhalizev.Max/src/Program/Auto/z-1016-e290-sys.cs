using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_e290-d585cef6")]
        public void /* sys */ Method_1016_e290()
        {
            ii(0x1016_e290, 1); push(ecx);                              /* push ecx */
            ii(0x1016_e291, 1); push(esi);                              /* push esi */
            ii(0x1016_e292, 3); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1016_e295, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_e297, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_e299, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_e29b, 5); call(/* sys */ 0x1017_0944, 0x26a4);    /* call 0x10170944 */
            ii(0x1016_e2a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e2a2, 2); if(jnz(0x1016_e2e0, 0x3c)) goto l_0x1016_e2e0; /* jnz 0x1016e2e0 */
            ii(0x1016_e2a4, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_e2a7, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_e2a9, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_e2ab, 5); call(/* sys */ 0x1017_09dc, 0x272c);    /* call 0x101709dc */
            ii(0x1016_e2b0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e2b2, 2); if(jnz(0x1016_e2d8, 0x24)) goto l_0x1016_e2d8; /* jnz 0x1016e2d8 */
            ii(0x1016_e2b4, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_e2b7, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1016_e2b9, 5); call(/* sys */ 0x1017_0c8c, 0x29ce);    /* call 0x10170c8c */
            ii(0x1016_e2be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_e2c0, 2); if(jnz(0x1016_e2d8, 0x16)) goto l_0x1016_e2d8; /* jnz 0x1016e2d8 */
            ii(0x1016_e2c2, 7); cmp(memd[ds, 0x101b_e1c0], 0);          /* cmp dword [0x101be1c0], 0x0 */
            ii(0x1016_e2c9, 2); if(jnz(0x1016_e2d3, 8)) goto l_0x1016_e2d3; /* jnz 0x1016e2d3 */
            ii(0x1016_e2cb, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_e2ce, 5); mov(memd[ds, 0x101b_e1c0], eax);        /* mov [0x101be1c0], eax */
        l_0x1016_e2d3:
            ii(0x1016_e2d3, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_e2d6, 2); jmp(0x1016_e2e5, 0xd); goto l_0x1016_e2e5; /* jmp 0x1016e2e5 */
        l_0x1016_e2d8:
            ii(0x1016_e2d8, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_e2db, 5); call(/* sys */ 0x1016_e36c, 0x8c);      /* call 0x1016e36c */
        l_0x1016_e2e0:
            ii(0x1016_e2e0, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_e2e5:
            ii(0x1016_e2e5, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1016_e2e8, 1); pop(esi);                               /* pop esi */
            ii(0x1016_e2e9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_e2ea, 1); ret();                                  /* ret */
        }
    }
}
