using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d7c5-4d238997")]
        public void /* sys */ Method_1018_d7c5()
        {
            ii(0x1018_d7c5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_d7c6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_d7c7, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d7c8, 1); pushd(esi);                             /* push esi */
            ii(0x1018_d7c9, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_d7cc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_d7ce, 2); mov(ah, 0x2a);                          /* mov ah, 0x2a */
            ii(0x1018_d7d0, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d7d2, 5); sub(cx, 0x76c);                         /* sub cx, 0x76c */
            ii(0x1018_d7d7, 2); mov(ch, al);                            /* mov ch, al */
            ii(0x1018_d7d9, 3); shl(ecx, 0x10);                         /* shl ecx, 0x10 */
            ii(0x1018_d7dc, 3); mov(cx, dx);                            /* mov cx, dx */
            ii(0x1018_d7df, 4); mov(memd_a32[ss, esp + 0x8], ecx);      /* mov [esp+0x8], ecx */
            ii(0x1018_d7e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d7e5, 4); mov(al, memb_a32[ss, esp + 0xa]);       /* mov al, [esp+0xa] */
            ii(0x1018_d7e9, 3); mov(memd_a32[ds, ebx + 0x14], eax);     /* mov [ebx+0x14], eax */
            ii(0x1018_d7ec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d7ee, 4); mov(al, memb_a32[ss, esp + 0x9]);       /* mov al, [esp+0x9] */
            ii(0x1018_d7f2, 1); dec(eax);                               /* dec eax */
            ii(0x1018_d7f3, 3); mov(memd_a32[ds, ebx + 0x10], eax);     /* mov [ebx+0x10], eax */
            ii(0x1018_d7f6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d7f8, 4); mov(al, memb_a32[ss, esp + 0x8]);       /* mov al, [esp+0x8] */
            ii(0x1018_d7fc, 3); mov(memd_a32[ds, ebx + 0xc], eax);      /* mov [ebx+0xc], eax */
            ii(0x1018_d7ff, 2); mov(ah, 0x2c);                          /* mov ah, 0x2c */
            ii(0x1018_d801, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d803, 3); shl(ecx, 0x10);                         /* shl ecx, 0x10 */
            ii(0x1018_d806, 3); mov(cx, dx);                            /* mov cx, dx */
            ii(0x1018_d809, 3); mov(memd_a32[ss, esp], ecx);            /* mov [esp], ecx */
            ii(0x1018_d80c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d80e, 4); mov(al, memb_a32[ss, esp + 0x3]);       /* mov al, [esp+0x3] */
            ii(0x1018_d812, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_d814, 3); mov(memd_a32[ds, ebx + 0x8], eax);      /* mov [ebx+0x8], eax */
            ii(0x1018_d817, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d819, 3); mov(cl, memb_a32[ss, esp]);             /* mov cl, [esp] */
            ii(0x1018_d81c, 4); mov(al, memb_a32[ss, esp + 0x2]);       /* mov al, [esp+0x2] */
            ii(0x1018_d820, 2); mov(esi, ecx);                          /* mov esi, ecx */
            ii(0x1018_d822, 3); mov(memd_a32[ds, ebx + 0x4], eax);      /* mov [ebx+0x4], eax */
            ii(0x1018_d825, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d827, 3); shl(esi, 0x2);                          /* shl esi, 0x2 */
            ii(0x1018_d82a, 4); mov(al, memb_a32[ss, esp + 0x1]);       /* mov al, [esp+0x1] */
            ii(0x1018_d82e, 2); add(esi, ecx);                          /* add esi, ecx */
            ii(0x1018_d830, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1018_d832, 2); mov(ah, 0x2a);                          /* mov ah, 0x2a */
            ii(0x1018_d834, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d836, 5); sub(cx, 0x76c);                         /* sub cx, 0x76c */
            ii(0x1018_d83b, 2); mov(ch, al);                            /* mov ch, al */
            ii(0x1018_d83d, 3); shl(ecx, 0x10);                         /* shl ecx, 0x10 */
            ii(0x1018_d840, 3); mov(cx, dx);                            /* mov cx, dx */
            ii(0x1018_d843, 4); mov(memd_a32[ss, esp + 0x4], ecx);      /* mov [esp+0x4], ecx */
            ii(0x1018_d847, 4); mov(al, memb_a32[ss, esp + 0x4]);       /* mov al, [esp+0x4] */
            ii(0x1018_d84b, 4); mov(ah, memb_a32[ss, esp + 0x8]);       /* mov ah, [esp+0x8] */
            ii(0x1018_d84f, 2); add(esi, esi);                          /* add esi, esi */
            ii(0x1018_d851, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1018_d853, 2); if(jzd(0x1018_d877, 0x22)) goto l_0x1018_d877; /* jz 0x1018d877 */
            ii(0x1018_d855, 4); cmp(memd_a32[ds, ebx + 0x8], 0x17);     /* cmp dword [ebx+0x8], 0x17 */
            ii(0x1018_d859, 2); if(jzd(0x1018_d877, 0x1c)) goto l_0x1018_d877; /* jz 0x1018d877 */
            ii(0x1018_d85b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d85d, 4); mov(al, memb_a32[ss, esp + 0x6]);       /* mov al, [esp+0x6] */
            ii(0x1018_d861, 3); mov(memd_a32[ds, ebx + 0x14], eax);     /* mov [ebx+0x14], eax */
            ii(0x1018_d864, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d866, 4); mov(al, memb_a32[ss, esp + 0x5]);       /* mov al, [esp+0x5] */
            ii(0x1018_d86a, 1); dec(eax);                               /* dec eax */
            ii(0x1018_d86b, 3); mov(memd_a32[ds, ebx + 0x10], eax);     /* mov [ebx+0x10], eax */
            ii(0x1018_d86e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_d870, 4); mov(al, memb_a32[ss, esp + 0x4]);       /* mov al, [esp+0x4] */
            ii(0x1018_d874, 3); mov(memd_a32[ds, ebx + 0xc], eax);      /* mov [ebx+0xc], eax */
        l_0x1018_d877:
            ii(0x1018_d877, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_d879, 7); mov(memd_a32[ds, ebx + 0x20], 0xffff_ffff); /* mov dword [ebx+0x20], 0xffffffff */
            ii(0x1018_d880, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1018_d883, 1); popd(esi);                              /* pop esi */
            ii(0x1018_d884, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d885, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_d886, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d887, 1); retd();                                 /* ret */
        }
    }
}
