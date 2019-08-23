using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_f6e8-d299c3fc")]
        public void /* sys */ Method_1016_f6e8()
        {
            ii(0x1016_f6e8, 1); push(ebx);                              /* push ebx */
            ii(0x1016_f6e9, 1); push(ecx);                              /* push ecx */
            ii(0x1016_f6ea, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_f6ed, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_f6ef, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_f6f1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_f6f3, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1016_f6f6, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_f6fb, 4); mov(memw[ss, esp], ax);                 /* mov [esp], ax */
            ii(0x1016_f6ff, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1016_f704, 3); sar(eax, 0x8);                          /* sar eax, 0x8 */
            ii(0x1016_f707, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_f709, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f70e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_f710, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_f712, 5); call(/* sys */ 0x1016_f63c, -0xdb);     /* call 0x1016f63c */
            ii(0x1016_f717, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f71a, 2); if(jz(0x1016_f72a, 0xe)) goto l_0x1016_f72a; /* jz 0x1016f72a */
            ii(0x1016_f71c, 3); mov(al, memb[ss, esp]);                 /* mov al, [esp] */
            ii(0x1016_f71f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_f721, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_f723, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_f725, 5); call(/* sys */ 0x1016_f63c, -0xee);     /* call 0x1016f63c */
        l_0x1016_f72a:
            ii(0x1016_f72a, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f72d, 2); if(jz(0x1016_f760, 0x31)) goto l_0x1016_f760; /* jz 0x1016f760 */
            ii(0x1016_f72f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f731, 3); mov(ax, cx);                            /* mov ax, cx */
            ii(0x1016_f734, 3); sar(eax, 0x8);                          /* sar eax, 0x8 */
            ii(0x1016_f737, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_f739, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f73e, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_f740, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_f742, 5); mov(memw[ss, esp + 0x4], cx);           /* mov [esp+0x4], cx */
            ii(0x1016_f747, 5); call(/* sys */ 0x1016_f63c, -0x110);    /* call 0x1016f63c */
            ii(0x1016_f74c, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f74f, 2); if(jz(0x1016_f760, 0xf)) goto l_0x1016_f760; /* jz 0x1016f760 */
            ii(0x1016_f751, 4); mov(al, memb[ss, esp + 0x4]);           /* mov al, [esp+0x4] */
            ii(0x1016_f755, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_f757, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_f759, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_f75b, 5); call(/* sys */ 0x1016_f63c, -0x124);    /* call 0x1016f63c */
        l_0x1016_f760:
            ii(0x1016_f760, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_f763, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_f764, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_f765, 1); ret();                                  /* ret */
        }
    }
}
