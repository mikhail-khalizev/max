using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fb4e-6c0a0c9c")]
        public void Method_0018_fb4e()
        {
            ii(0x18_fb4e, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x18_fb51, 4); movzx(esi, bp);                           /* movzx esi, bp */
            ii(0x18_fb55, 3); mov(es, memw[ds, si + 2]);                /* mov es, [si+0x2] */
            ii(0x18_fb58, 4); mov(edi, memd[ds, si + 0x18]);            /* mov edi, [si+0x18] */
            ii(0x18_fb5c, 4); sub(edi, 0x3a);                           /* sub edi, 0x3a */
            ii(0x18_fb60, 4); movzx(eax, memw[ds, si]);                 /* movzx eax, word [si] */
            ii(0x18_fb64, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x18_fb66, 3); mov(ebp, edi);                            /* mov ebp, edi */
            ii(0x18_fb69, 4); add(si, 4);                               /* add si, 0x4 */
            ii(0x18_fb6d, 1); cld();                                    /* cld */
            ii(0x18_fb6e, 6); mov(ecx, 0xe);                            /* mov ecx, 0xe */
            ii(0x18_fb74, 4); rep_a32(() => movsd_a32());               /* a32 rep movsd */
            ii(0x18_fb78, 2); nop();                                    /* a32 nop */
            ii(0x18_fb7a, 2); movsw_a32();                              /* a32 movsw */
            ii(0x18_fb7c, 2); mov(ss, bx);                              /* mov ss, bx */
            ii(0x18_fb7e, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x18_fb81, 4); mov(memd[ds, 0xa42], eax);                /* mov [0xa42], eax */
            ii(0x18_fb85, 5); test(memb_a32[ss, ebp + 0x37], 2);        /* test byte [ebp+0x37], 0x2 */
            ii(0x18_fb8a, 2); if(jz(0x18_fb8d, 1)) goto l_0x18_fb8d;    /* jz 0xfb8d */
            ii(0x18_fb8c, 1); sti();                                    /* sti */
        l_0x18_fb8d:
            ii(0x18_fb8d, 1); pop(ds);                                  /* pop ds */
            ii(0x18_fb8e, 1); pop(es);                                  /* pop es */
            ii(0x18_fb8f, 2); pop(fs);                                  /* pop fs */
            ii(0x18_fb91, 2); pop(gs);                                  /* pop gs */
            ii(0x18_fb93, 2); popad();                                  /* popad */
            ii(0x18_fb95, 4); add(esp, 6);                              /* add esp, 0x6 */
            ii(0x18_fb99, 2); iretd();                                  /* iretd */
        }
    }
}
