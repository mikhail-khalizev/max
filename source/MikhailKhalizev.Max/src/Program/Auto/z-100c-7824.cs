using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7824-430f1a87")]
        public void Method_100c_7824()
        {
            ii(0x100c_7824, 5); push(0x44);                             /* push 0x44 */
            ii(0x100c_7829, 5); call(Definitions.sys_check_available_stack_size, 0x9_e524); /* call 0x10165d52 */
            ii(0x100c_782e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_782f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7830, 1); push(esi);                              /* push esi */
            ii(0x100c_7831, 1); push(edi);                              /* push edi */
            ii(0x100c_7832, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7833, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7835, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100c_783b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_783e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_7841, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100c_7846, 3); lea(edx, memd[ss, ebp - 16]);           /* lea edx, [ebp-0x10] */
            ii(0x100c_7849, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_784c, 5); call(0x100c_6677, -0x11da);             /* call 0x100c6677 */
            ii(0x100c_7851, 4); or(memb[ss, ebp - 12], 1);              /* or byte [ebp-0xc], 0x1 */
            ii(0x100c_7855, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7858, 5); call(0x100c_9fb4, 0x2757);              /* call 0x100c9fb4 */
            ii(0x100c_785d, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_7860, 4); and(memb[ss, ebp - 12], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100c_7864, 5); call(0x100c_aef4, 0x368b);              /* call 0x100caef4 */
            ii(0x100c_7869, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_786b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_786d, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x100c_7870, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_7873, 5); call(0x100c_ae64, 0x35ec);              /* call 0x100cae64 */
            ii(0x100c_7878, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_787a, 5); call(0x100c_aef4, 0x3675);              /* call 0x100caef4 */
            ii(0x100c_787f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_7881, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_7883, 3); lea(edx, memd[ss, ebp - 16]);           /* lea edx, [ebp-0x10] */
            ii(0x100c_7886, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100c_7889, 5); call(0x100c_ae64, 0x35d6);              /* call 0x100cae64 */
            ii(0x100c_788e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7890, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7893, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100c_7895, 5); call(0x100c_63af, -0x14eb);             /* call 0x100c63af */
            ii(0x100c_789a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_789c, 3); lea(eax, memd[ss, ebp - 32]);           /* lea eax, [ebp-0x20] */
            ii(0x100c_789f, 5); call(0x100c_a6a0, 0x2dfc);              /* call 0x100ca6a0 */
            ii(0x100c_78a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_78a6, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x100c_78a9, 5); call(0x100c_a6a0, 0x2df2);              /* call 0x100ca6a0 */
        l_0x100c_78ae:
            ii(0x100c_78ae, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_78b1, 5); cmp(memw[ds, eax + 10], -1 /* 0xff */); /* cmp word [eax+0xa], 0xffff */
            ii(0x100c_78b6, 2); if(jz(0x100c_78c5, 0xd)) goto l_0x100c_78c5; /* jz 0x100c78c5 */
            ii(0x100c_78b8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_78bb, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100c_78bf, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100c_78c3, 2); if(jle(0x100c_78ca, 5)) goto l_0x100c_78ca; /* jle 0x100c78ca */
        l_0x100c_78c5:
            ii(0x100c_78c5, 5); jmp(0x100c_7984, 0xba); goto l_0x100c_7984; /* jmp 0x100c7984 */
        l_0x100c_78ca:
            ii(0x100c_78ca, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_78cd, 4); mov(ax, memw[ds, eax + 12]);            /* mov ax, [eax+0xc] */
            ii(0x100c_78d1, 3); sub(memd[ss, ebp - 4], eax);            /* sub [ebp-0x4], eax */
            ii(0x100c_78d4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_78d7, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_78da, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100c_78dd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_78e0, 4); mov(dx, memw[ds, edx + 12]);            /* mov dx, [edx+0xc] */
            ii(0x100c_78e4, 7); sub(memw[ds, eax + 0x101c_35c4], dx);   /* sub [eax+0x101c35c4], dx */
            ii(0x100c_78eb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_78ee, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_78f1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_78f7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_78fa, 4); mov(dx, memw[ds, edx + 12]);            /* mov dx, [edx+0xc] */
            ii(0x100c_78fe, 7); add(memw[ds, eax + 0x101c_a583], dx);   /* add [eax+0x101ca583], dx */
            ii(0x100c_7905, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7908, 5); call(0x100c_79a0, 0x93);                /* call 0x100c79a0 */
            ii(0x100c_790d, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100c_7912, 3); lea(edx, memd[ss, ebp - 36]);           /* lea edx, [ebp-0x24] */
            ii(0x100c_7915, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7918, 5); call(0x100c_6677, -0x12a6);             /* call 0x100c6677 */
            ii(0x100c_791d, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x100c_7920, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7922, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_7924, 5); call(0x100c_ad30, 0x3407);              /* call 0x100cad30 */
            ii(0x100c_7929, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_792b, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x100c_792e, 5); call(0x100c_a6a0, 0x2d6d);              /* call 0x100ca6a0 */
            ii(0x100c_7933, 5); call(0x100c_aef4, 0x35bc);              /* call 0x100caef4 */
            ii(0x100c_7938, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_793a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_793c, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x100c_793f, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100c_7942, 5); call(0x100c_ae64, 0x351d);              /* call 0x100cae64 */
            ii(0x100c_7947, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_7949, 5); call(0x100c_aef4, 0x35a6);              /* call 0x100caef4 */
            ii(0x100c_794e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_7950, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_7952, 3); lea(edx, memd[ss, ebp - 16]);           /* lea edx, [ebp-0x10] */
            ii(0x100c_7955, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100c_7958, 5); call(0x100c_ae64, 0x3507);              /* call 0x100cae64 */
            ii(0x100c_795d, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x100c_7960, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x100c_7962, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7964, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_7966, 5); call(0x100c_63af, -0x15bc);             /* call 0x100c63af */
            ii(0x100c_796b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_796d, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100c_7970, 5); call(0x100c_a6a0, 0x2d2b);              /* call 0x100ca6a0 */
            ii(0x100c_7975, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7977, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x100c_797a, 5); call(0x100c_a6a0, 0x2d21);              /* call 0x100ca6a0 */
            ii(0x100c_797f, 5); jmp(0x100c_78ae, -0xd6); goto l_0x100c_78ae; /* jmp 0x100c78ae */
        l_0x100c_7984:
            ii(0x100c_7984, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7986, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x100c_7989, 5); call(0x100c_a6a0, 0x2d12);              /* call 0x100ca6a0 */
            ii(0x100c_798e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7990, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100c_7993, 5); call(0x100c_a6a0, 0x2d08);              /* call 0x100ca6a0 */
            ii(0x100c_7998, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_799a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_799b, 1); pop(edi);                               /* pop edi */
            ii(0x100c_799c, 1); pop(esi);                               /* pop esi */
            ii(0x100c_799d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_799e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_799f, 1); ret();                                  /* ret */
        }
    }
}
