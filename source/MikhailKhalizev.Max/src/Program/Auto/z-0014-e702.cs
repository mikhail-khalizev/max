using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7f0a045-31c7-4b36-ac87-43f47457212d")]
        public void Method_0014_e702()
        {
            ii(0x14_e702, 3); mov(cx, 0x20);                            /* mov cx, 0x20 */
            ii(0x14_e705, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x14_e707, 3); mov(ax, memw_a16[ds, 0x996]);             /* mov ax, [0x996] */
            ii(0x14_e70a, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x14_e70c, 4); sub(bx, 0x156);                           /* sub bx, 0x156 */
            ii(0x14_e710, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x14_e712, 4); mov(memw_a16[ds, 0x996], bx);             /* mov [0x996], bx */
            ii(0x14_e716, 3); mov(memw_a16[ds, bx + 0x2], ss);          /* mov [bx+0x2], ss */
            ii(0x14_e719, 4); mov(memd_a16[ds, bx + 0xc], ebp);         /* mov [bx+0xc], ebp */
            ii(0x14_e71d, 3); mov(memw_a16[ds, bx + 0x6], es);          /* mov [bx+0x6], es */
            ii(0x14_e720, 4); mov(memd_a16[ds, bx + 0x8], edi);         /* mov [bx+0x8], edi */
            ii(0x14_e724, 5); mov(memw_a16[ds, bx + 0x22], 0xffff);     /* mov word [bx+0x22], 0xffff */
            ii(0x14_e729, 5); mov(cx, memw_a32[es, edi + 0x30]);        /* mov cx, [es:edi+0x30] */
            ii(0x14_e72e, 3); mov(esi, edi);                            /* mov esi, edi */
            ii(0x14_e731, 2); if(jcxzw(0x14_e74b, 0x18)) goto l_0x14_e74b; /* jcxz 0xe74b */
            ii(0x14_e733, 1); pushw(cx);                                /* push cx */
            ii(0x14_e734, 3); mov(ax, 0x10);                            /* mov ax, 0x10 */
            ii(0x14_e737, 2); mul(cx);                                  /* mul cx */
            ii(0x14_e739, 7); movzx(edi, memw_a32[es, edi + 0x2e]);     /* movzx edi, word [es:edi+0x2e] */
            ii(0x14_e740, 1); pushw(bx);                                /* push bx */
            ii(0x14_e741, 3); callw(0x14_e60b, -0x139);                 /* call 0xe60b */
            ii(0x14_e744, 1); popw(bx);                                 /* pop bx */
            ii(0x14_e745, 1); popw(dx);                                 /* pop dx */
            ii(0x14_e746, 2); jmpw(0x14_e757, 0xf); goto l_0x14_e757;   /* jmp 0xe757 */
        l_0x14_e748:
            ii(0x14_e748, 3); if(jmpw_func(0x14_e062, -0x6e9)) return;  /* jmp 0xe062 */
        l_0x14_e74b:
            ii(0x14_e74b, 3); sub(bx, 0x10);                            /* sub bx, 0x10 */
            ii(0x14_e74e, 4); movzx(edi, bx);                           /* movzx edi, bx */
            ii(0x14_e752, 1); pushw(ds);                                /* push ds */
            ii(0x14_e753, 1); popw(es);                                 /* pop es */
            ii(0x14_e754, 3); mov(dx, 0x1a2);                           /* mov dx, 0x1a2 */
        l_0x14_e757:
            ii(0x14_e757, 6); movzx(ecx, memw_a32[ss, ebp + 0x1c]);     /* movzx ecx, word [ebp+0x1c] */
            ii(0x14_e75d, 2); add(cx, cx);                              /* add cx, cx */
            ii(0x14_e75f, 3); cmp(cx, 0x40);                            /* cmp cx, 0x40 */
            ii(0x14_e762, 2); if(jaw(0x14_e748, -0x1c)) goto l_0x14_e748; /* ja 0xe748 */
            ii(0x14_e764, 2); sub(bx, cx);                              /* sub bx, cx */
            ii(0x14_e766, 2); if(jcxzw(0x14_e77d, 0x15)) goto l_0x14_e77d; /* jcxz 0xe77d */
            ii(0x14_e768, 2); pushd(esi);                               /* push esi */
            ii(0x14_e76a, 1); std();                                    /* std */
            ii(0x14_e76b, 5); lea(esi, ebp + 0x2f);                     /* lea esi, [ebp+0x2f] */
            ii(0x14_e770, 3); add(esi, ecx);                            /* add esi, ecx */
            ii(0x14_e773, 1); dec(di);                                  /* dec di */
            ii(0x14_e774, 4); rep_a32(() => movsb_a32(ss));             /* a32 ss rep movsb */
            ii(0x14_e778, 2); inc(di);                                  /* a32 inc di */
            ii(0x14_e77a, 1); cld();                                    /* cld */
            ii(0x14_e77b, 2); popd(esi);                                /* pop esi */
        l_0x14_e77d:
            ii(0x14_e77d, 3); lea(di, di - 0x32);                       /* lea di, [di-0x32] */
            ii(0x14_e780, 1); retw(); return;                           /* ret */
        }
    }
}
