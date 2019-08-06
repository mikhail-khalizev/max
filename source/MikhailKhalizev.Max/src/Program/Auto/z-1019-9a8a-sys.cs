using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("17bebabe-8896-4125-b7ec-a832152de241")]
        public void /* sys */ Method_1019_9a8a()
        {
            ii(0x1019_9a8a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_9a8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_9a8c, 1); pushd(esi);                             /* push esi */
            ii(0x1019_9a8d, 1); pushd(edi);                             /* push edi */
            ii(0x1019_9a8e, 1); pushd(es);                              /* push es */
            ii(0x1019_9a8f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_9a90, 1); pushd(edx);                             /* push edx */
            ii(0x1019_9a91, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1019_9a93, 4); mov(ax, 0x1600);                        /* mov ax, 0x1600 */
            ii(0x1019_9a97, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9a99, 2); test(al, al);                           /* test al, al */
            ii(0x1019_9a9b, 2); if(jzd(0x1019_9afa, 0x5d)) goto l_0x1019_9afa; /* jz 0x10199afa */
            ii(0x1019_9a9d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_9aa2, 5); cmp(eax, 0x80);                         /* cmp eax, 0x80 */
            ii(0x1019_9aa7, 2); if(jzd(0x1019_9afa, 0x51)) goto l_0x1019_9afa; /* jz 0x10199afa */
            ii(0x1019_9aa9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_9aab, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_9aad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_9aaf, 2); xor(al, al);                            /* xor al, al */
            ii(0x1019_9ab1, 2); mov(ah, 0xfa);                          /* mov ah, 0xfa */
            ii(0x1019_9ab3, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9ab5, 1); cwde();                                 /* cwde */
            ii(0x1019_9ab6, 5); cmp(eax, 0x666);                        /* cmp eax, 0x666 */
            ii(0x1019_9abb, 2); if(jnzd(0x1019_9afa, 0x3d)) goto l_0x1019_9afa; /* jnz 0x10199afa */
            ii(0x1019_9abd, 2); mov(al, 0x22);                          /* mov al, 0x22 */
            ii(0x1019_9abf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_9ac1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_9ac3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_9ac5, 2); mov(ah, 0xfa);                          /* mov ah, 0xfa */
            ii(0x1019_9ac7, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9ac9, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1019_9acc, 2); if(jnzd(0x1019_9afa, 0x2c)) goto l_0x1019_9afa; /* jnz 0x10199afa */
            ii(0x1019_9ace, 2); mov(dh, 0x1);                           /* mov dh, 0x1 */
            ii(0x1019_9ad0, 2); mov(al, 0x1e);                          /* mov al, 0x1e */
            ii(0x1019_9ad2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_9ad4, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_9ad6, 6); mov(memb_a32[ds, 0x101c_1c41], dh);     /* mov [0x101c1c41], dh */
            ii(0x1019_9adc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_9ade, 2); mov(ah, 0xfa);                          /* mov ah, 0xfa */
            ii(0x1019_9ae0, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9ae2, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1019_9ae4, 5); mov(ebx, 0x1020_bcbc);                  /* mov ebx, 0x1020bcbc */
            ii(0x1019_9ae9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_9aeb, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1019_9aed, 2); mov(al, 0x20);                          /* mov al, 0x20 */
            ii(0x1019_9aef, 3); shr(ecx, 0x10);                         /* shr ecx, 0x10 */
            ii(0x1019_9af2, 2); mov(ah, 0xfa);                          /* mov ah, 0xfa */
            ii(0x1019_9af4, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_9af6, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1019_9af8, 2); jmpd(0x1019_9b54, 0x5a); goto l_0x1019_9b54; /* jmp 0x10199b54 */
        l_0x1019_9afa:
            ii(0x1019_9afa, 3); mov(edx, memd_a32[ss, esp]);            /* mov edx, [esp] */
            ii(0x1019_9afd, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1019_9aff, 2); if(jnzd(0x1019_9b06, 0x5)) goto l_0x1019_9b06; /* jnz 0x10199b06 */
            ii(0x1019_9b01, 3); test(dx, dx);                           /* test dx, dx */
            ii(0x1019_9b04, 2); if(jzd(0x1019_9b52, 0x4c)) goto l_0x1019_9b52; /* jz 0x10199b52 */
        l_0x1019_9b06:
            ii(0x1019_9b06, 5); mov(eax, 0xa00);                        /* mov eax, 0xa00 */
            ii(0x1019_9b0b, 5); mov(esi, StringDefinitions.RationalDos4g); /* mov esi, 0x101b36fc */
            ii(0x1019_9b10, 1); pushd(es);                              /* push es */
            ii(0x1019_9b11, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_9b13, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1019_9b15, 1); popd(es);                               /* pop es */
            ii(0x1019_9b16, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_9b18, 2); if(jnzd(0x1019_9b52, 0x38)) goto l_0x1019_9b52; /* jnz 0x10199b52 */
            ii(0x1019_9b1a, 5); mov(ebx, /* sys */ 0x1019_6c4c);        /* mov ebx, 0x10196c4c */
            ii(0x1019_9b1f, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1019_9b24, 2); mov(ecx, cs);                           /* mov ecx, cs */
            ii(0x1019_9b26, 5); calld(/* sys */ 0x1017_92f0, -0x2083b); /* call 0x101792f0 */
            ii(0x1019_9b2b, 3); mov(es, memw_a32[ss, esp]);             /* mov es, [esp] */
            ii(0x1019_9b2e, 4); mov(ah, memb_a32[es, ebp + 0x40]);      /* mov ah, [es:ebp+0x40] */
            ii(0x1019_9b32, 5); mov(memb_a32[es, ebp + 0x3e], 0x1);     /* mov byte [es:ebp+0x3e], 0x1 */
            ii(0x1019_9b37, 3); or(ah, 0x4);                            /* or ah, 0x4 */
            ii(0x1019_9b3a, 4); mov(memb_a32[es, ebp + 0x40], ah);      /* mov [es:ebp+0x40], ah */
            ii(0x1019_9b3e, 3); mov(eax, cr0);                          /* mov eax, cr0 */
            ii(0x1019_9b41, 2); or(al, 0x4);                            /* or al, 0x4 */
            ii(0x1019_9b43, 2); mov(dl, 0x1);                           /* mov dl, 0x1 */
            ii(0x1019_9b45, 3); mov(cr0, eax);                          /* mov cr0, eax */
            ii(0x1019_9b48, 2); mov(ah, 0x30);                          /* mov ah, 0x30 */
            ii(0x1019_9b4a, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_9b4c, 6); mov(memb_a32[ds, 0x101c_1c40], dl);     /* mov [0x101c1c40], dl */
        l_0x1019_9b52:
            ii(0x1019_9b52, 2); xor(al, al);                            /* xor al, al */
        l_0x1019_9b54:
            ii(0x1019_9b54, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1019_9b57, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_9b58, 1); popd(es);                               /* pop es */
            ii(0x1019_9b59, 1); popd(edi);                              /* pop edi */
            ii(0x1019_9b5a, 1); popd(esi);                              /* pop esi */
            ii(0x1019_9b5b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_9b5c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_9b5d, 1); retd(); return;                         /* ret */
        }
    }
}
