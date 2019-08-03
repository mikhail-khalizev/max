using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("44422270-9dcd-4290-88fe-702d09b282c0")]
        public void /* sys */ Method_1019_bf15()
        {
            ii(0x1019_bf15, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_bf16, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_bf17, 1); pushd(edx);                             /* push edx */
            ii(0x1019_bf18, 1); pushd(esi);                             /* push esi */
            ii(0x1019_bf19, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_bf1c, 7); cmp(memd_a32[ds, 0x101c_1d2c], 0);      /* cmp dword [0x101c1d2c], 0x0 */
            ii(0x1019_bf23, 6); if(jnzd(0x1019_bf9c, 0x73)) goto l_0x1019_bf9c; /* jnz 0x1019bf9c */
            ii(0x1019_bf29, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_bf2b, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1019_bf30, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1019_bf33, 2); if(jzd(0x1019_bf40, 0xb)) goto l_0x1019_bf40; /* jz 0x1019bf40 */
            ii(0x1019_bf35, 4); mov(ax, 0x1686);                        /* mov ax, 0x1686 */
            ii(0x1019_bf39, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_bf3b, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1019_bf3e, 2); if(jnzd(0x1019_bf92, 0x52)) goto l_0x1019_bf92; /* jnz 0x1019bf92 */
        l_0x1019_bf40:
            ii(0x1019_bf40, 2); mov(esi, esp);                          /* mov esi, esp */
            ii(0x1019_bf42, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1019_bf44, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1019_bf46, 3); mov(memb_a32[ss, esp], ah);             /* mov [esp], ah */
            ii(0x1019_bf49, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1019_bf4b, 4); mov(memb_a32[ss, esp + 0x1], ah);       /* mov [esp+0x1], ah */
            ii(0x1019_bf4f, 5); mov(memw_a32[ss, esp + 0x2], dx);       /* mov [esp+0x2], dx */
            ii(0x1019_bf54, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1019_bf56, 4); mov(memb_a32[ss, esp + 0x4], ah);       /* mov [esp+0x4], ah */
            ii(0x1019_bf5a, 1); pushd(ds);                              /* push ds */
            ii(0x1019_bf5b, 2); mov(ds, edx);                           /* mov ds, edx */
            ii(0x1019_bf5d, 4); mov(ax, 0x400);                         /* mov ax, 0x400 */
            ii(0x1019_bf61, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_bf63, 2); mov(memb_a32[ds, esi], ah);             /* mov [esi], ah */
            ii(0x1019_bf65, 3); mov(memb_a32[ds, esi + 0x1], al);       /* mov [esi+0x1], al */
            ii(0x1019_bf68, 4); mov(memw_a32[ds, esi + 0x2], bx);       /* mov [esi+0x2], bx */
            ii(0x1019_bf6c, 3); mov(memb_a32[ds, esi + 0x4], cl);       /* mov [esi+0x4], cl */
            ii(0x1019_bf6f, 3); mov(memb_a32[ds, esi + 0x5], dh);       /* mov [esi+0x5], dh */
            ii(0x1019_bf72, 3); mov(memb_a32[ds, esi + 0x6], dl);       /* mov [esi+0x6], dl */
            ii(0x1019_bf75, 1); popd(ds);                               /* pop ds */
            ii(0x1019_bf76, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_bf78, 5); movzx(esi, memb_a32[ss, esp + 0x1]);    /* movzx esi, byte [esp+0x1] */
            ii(0x1019_bf7d, 3); mov(al, memb_a32[ss, esp]);             /* mov al, [esp] */
            ii(0x1019_bf80, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1019_bf82, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_bf84, 2); if(jled(0x1019_bf92, 0xc)) goto l_0x1019_bf92; /* jle 0x1019bf92 */
            ii(0x1019_bf86, 10); mov(memd_a32[ds, 0x101c_1d2c], 0x1);   /* mov dword [0x101c1d2c], 0x1 */
            ii(0x1019_bf90, 2); jmpd(0x1019_bf9c, 0xa); goto l_0x1019_bf9c; /* jmp 0x1019bf9c */
        l_0x1019_bf92:
            ii(0x1019_bf92, 10); mov(memd_a32[ds, 0x101c_1d2c], 0xffff_ffff); /* mov dword [0x101c1d2c], 0xffffffff */
        l_0x1019_bf9c:
            ii(0x1019_bf9c, 5); mov(eax, memd_a32[ds, 0x101c_1d2c]);    /* mov eax, [0x101c1d2c] */
            ii(0x1019_bfa1, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_bfa4, 1); popd(esi);                              /* pop esi */
            ii(0x1019_bfa5, 1); popd(edx);                              /* pop edx */
            ii(0x1019_bfa6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_bfa7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_bfa8, 1); retd(); return;                         /* ret */
        }
    }
}
