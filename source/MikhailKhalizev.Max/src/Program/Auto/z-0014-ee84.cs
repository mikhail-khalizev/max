using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("60596718-90d7-4f8d-b75b-c258e1b49dde")]
        public void Method_0014_ee84()
        {
            ii(0x14_ee84, 3); and(cx, 0x3f);                            /* and cx, 0x3f */
            ii(0x14_ee87, 2); pushd(ebp);                               /* push ebp */
            ii(0x14_ee89, 2); pushd(eax);                               /* push eax */
            ii(0x14_ee8b, 2); mov(bp, ss);                              /* mov bp, ss */
            ii(0x14_ee8d, 4); lar(ebp, bp);                             /* lar ebp, bp */
            ii(0x14_ee91, 4); shr(ebp, 0x17);                           /* shr ebp, 0x17 */
            ii(0x14_ee95, 2); if(jaew_func(0x14_ee98, 0x1)) return;     /* jae 0xee98 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x14_ee97, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x14_ee9a, 5); mov(eax, memd_a32[ss, ebp + 0xc]);        /* mov eax, [ebp+0xc] */
            ii(0x14_ee9f, 5); mov(ebp, memd_a32[ss, ebp + 0x10]);       /* mov ebp, [ebp+0x10] */
            ii(0x14_eea4, 3); cmp(cl, 0x8);                             /* cmp cl, 0x8 */
            ii(0x14_eea7, 2); if(jnzw(0x14_eeb3, 0xa)) goto l_0x14_eeb3; /* jnz 0xeeb3 */
            ii(0x14_eea9, 3); or(eax, eax);                             /* or eax, eax */
            ii(0x14_eeac, 2); if(jzw(0x14_ef0a, 0x5c)) goto l_0x14_ef0a; /* jz 0xef0a */
        l_0x14_eeae:
            ii(0x14_eeae, 2); popd(eax);                                /* pop eax */
            ii(0x14_eeb0, 2); popd(ebp);                                /* pop ebp */
            ii(0x14_eeb2, 1); retw(); return;                           /* ret */
        l_0x14_eeb3:
            ii(0x14_eeb3, 2); pushd(esi);                               /* push esi */
            ii(0x14_eeb5, 3); mov(esi, eax);                            /* mov esi, eax */
            ii(0x14_eeb8, 4); cmp(esi, 0x2);                            /* cmp esi, 0x2 */
            ii(0x14_eebc, 4); if(jbw(0x14_ef08, 0x48)) goto l_0x14_ef08; /* jb 0xef08 */
            ii(0x14_eec0, 3); lar(ax, bp);                              /* lar ax, bp */
            ii(0x14_eec3, 4); if(jnzw(0x14_ef08, 0x41)) goto l_0x14_ef08; /* jnz 0xef08 */
            ii(0x14_eec7, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x14_eec9, 2); and(al, 0x8a);                            /* and al, 0x8a */
            ii(0x14_eecb, 2); cmp(al, -0x76 /* 0x8a */);                /* cmp al, 0x8a */
            ii(0x14_eecd, 4); if(jnzw(0x14_ef08, 0x37)) goto l_0x14_ef08; /* jnz 0xef08 */
            ii(0x14_eed1, 3); shr(ah, 0x5);                             /* shr ah, 0x5 */
            ii(0x14_eed4, 3); and(ah, 0x3);                             /* and ah, 0x3 */
            ii(0x14_eed7, 1); pushw(bx);                                /* push bx */
            ii(0x14_eed8, 2); mov(bx, cs);                              /* mov bx, cs */
            ii(0x14_eeda, 3); and(bl, 0x3);                             /* and bl, 0x3 */
            ii(0x14_eedd, 2); mov(al, bl);                              /* mov al, bl */
            ii(0x14_eedf, 1); popw(bx);                                 /* pop bx */
            ii(0x14_eee0, 2); cmp(al, ah);                              /* cmp al, ah */
            ii(0x14_eee2, 4); if(jaw(0x14_ef08, 0x22)) goto l_0x14_ef08; /* ja 0xef08 */
            ii(0x14_eee6, 4); lsl(eax, bp);                             /* lsl eax, bp */
            ii(0x14_eeea, 3); cmp(esi, eax);                            /* cmp esi, eax */
            ii(0x14_eeed, 4); if(jaw(0x14_ef08, 0x17)) goto l_0x14_ef08; /* ja 0xef08 */
            ii(0x14_eef1, 2); mov(ah, cl);                              /* mov ah, cl */
            ii(0x14_eef3, 3); and(ah, 0x1f);                            /* and ah, 0x1f */
            ii(0x14_eef6, 2); mov(al, 0xcd);                            /* mov al, 0xcd */
            ii(0x14_eef8, 1); pushw(ds);                                /* push ds */
            ii(0x14_eef9, 2); mov(ds, bp);                              /* mov ds, bp */
            ii(0x14_eefb, 4); cmp(ax, memw_a32[ds, esi - 0x2]);         /* cmp ax, [esi-0x2] */
            ii(0x14_eeff, 1); popw(ds);                                 /* pop ds */
            ii(0x14_ef00, 2); popd(esi);                                /* pop esi */
            ii(0x14_ef02, 4); if(jnzw(0x14_ef0a, 0x4)) goto l_0x14_ef0a; /* jnz 0xef0a */
            ii(0x14_ef06, 2); jmpw(0x14_eeae, -0x5a); goto l_0x14_eeae; /* jmp 0xeeae */
        l_0x14_ef08:
            ii(0x14_ef08, 2); popd(esi);                                /* pop esi */
        l_0x14_ef0a:
            ii(0x14_ef0a, 2); popd(eax);                                /* pop eax */
            ii(0x14_ef0c, 2); popd(ebp);                                /* pop ebp */
        }
    }
}
