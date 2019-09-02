using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d5d9-ad177abd")]
        public void /* sys */ Method_1018_d5d9()
        {
            ii(0x1018_d5d9, 1); push(ebx);                              /* push ebx */
            ii(0x1018_d5da, 1); push(ecx);                              /* push ecx */
            ii(0x1018_d5db, 1); push(edx);                              /* push edx */
            ii(0x1018_d5dc, 1); push(esi);                              /* push esi */
            ii(0x1018_d5dd, 1); push(edi);                              /* push edi */
            ii(0x1018_d5de, 1); push(ebp);                              /* push ebp */
            ii(0x1018_d5df, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_d5e1, 3); mov(ah, memb[ds, eax + 13]);            /* mov ah, [eax+0xd] */
            ii(0x1018_d5e4, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_d5e6, 3); test(ah, 0x10);                         /* test ah, 0x10 */
            ii(0x1018_d5e9, 6); if(jz(0x1018_d665, 0x76)) goto l_0x1018_d665; /* jz 0x1018d665 */
            ii(0x1018_d5ef, 3); mov(bh, memb[ds, ecx + 13]);            /* mov bh, [ecx+0xd] */
            ii(0x1018_d5f2, 3); and(bh, 0xef);                          /* and bh, 0xef */
            ii(0x1018_d5f5, 3); mov(al, memb[ds, ecx + 12]);            /* mov al, [ecx+0xc] */
            ii(0x1018_d5f8, 3); mov(memb[ds, ecx + 13], bh);            /* mov [ecx+0xd], bh */
            ii(0x1018_d5fb, 2); test(al, 2);                            /* test al, 0x2 */
            ii(0x1018_d5fd, 6); if(jz(0x1018_d69d, 0x9a)) goto l_0x1018_d69d; /* jz 0x1018d69d */
            ii(0x1018_d603, 3); mov(ebx, memd[ds, ecx + 8]);            /* mov ebx, [ecx+0x8] */
            ii(0x1018_d606, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_d608, 6); if(jz(0x1018_d69d, 0x8f)) goto l_0x1018_d69d; /* jz 0x1018d69d */
            ii(0x1018_d60e, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1018_d610, 3); mov(esi, memd[ds, ecx + 4]);            /* mov esi, [ecx+0x4] */
        l_0x1018_d613:
            ii(0x1018_d613, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_d615, 6); if(jz(0x1018_d69d, 0x82)) goto l_0x1018_d69d; /* jz 0x1018d69d */
            ii(0x1018_d61b, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1018_d61d, 6); if(jnz(0x1018_d69d, 0x7a)) goto l_0x1018_d69d; /* jnz 0x1018d69d */
            ii(0x1018_d623, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_d625, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_d627, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1018_d62a, 5); call(/* sys */ 0x1018_d72e, 0xff);      /* call 0x1018d72e */
            ii(0x1018_d62f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d631, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_d634, 2); if(jnz(0x1018_d643, 0xd)) goto l_0x1018_d643; /* jnz 0x1018d643 */
            ii(0x1018_d636, 3); mov(bl, memb[ds, ecx + 12]);            /* mov bl, [ecx+0xc] */
            ii(0x1018_d639, 3); or(bl, 0x20);                           /* or bl, 0x20 */
            ii(0x1018_d63c, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_d63e, 3); mov(memb[ds, ecx + 12], bl);            /* mov [ecx+0xc], bl */
            ii(0x1018_d641, 2); jmp(0x1018_d65f, 0x1c); goto l_0x1018_d65f; /* jmp 0x1018d65f */
        l_0x1018_d643:
            ii(0x1018_d643, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d645, 2); if(jnz(0x1018_d65f, 0x18)) goto l_0x1018_d65f; /* jnz 0x1018d65f */
            ii(0x1018_d647, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1018_d64c, 5); call(/* sys */ 0x1018_d3bf, -0x292);    /* call 0x1018d3bf */
            ii(0x1018_d651, 3); mov(ah, memb[ds, ecx + 12]);            /* mov ah, [ecx+0xc] */
            ii(0x1018_d654, 3); or(ah, 0x20);                           /* or ah, 0x20 */
            ii(0x1018_d657, 5); mov(ebp, 0xffff_ffff);                  /* mov ebp, 0xffffffff */
            ii(0x1018_d65c, 3); mov(memb[ds, ecx + 12], ah);            /* mov [ecx+0xc], ah */
        l_0x1018_d65f:
            ii(0x1018_d65f, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_d661, 2); sub(esi, edx);                          /* sub esi, edx */
            ii(0x1018_d663, 2); jmp(0x1018_d613, -0x52); goto l_0x1018_d613; /* jmp 0x1018d613 */
        l_0x1018_d665:
            ii(0x1018_d665, 4); cmp(memd[ds, ecx + 8], 0);              /* cmp dword [ecx+0x8], 0x0 */
            ii(0x1018_d669, 2); if(jz(0x1018_d69d, 0x32)) goto l_0x1018_d69d; /* jz 0x1018d69d */
            ii(0x1018_d66b, 4); and(memb[ds, ecx + 12], -0x11 /* 0xef */); /* and byte [ecx+0xc], 0xef */
            ii(0x1018_d66f, 4); test(memb[ds, ecx + 13], 0x20);         /* test byte [ecx+0xd], 0x20 */
            ii(0x1018_d673, 2); if(jnz(0x1018_d69d, 0x28)) goto l_0x1018_d69d; /* jnz 0x1018d69d */
            ii(0x1018_d675, 3); mov(eax, memd[ds, ecx + 4]);            /* mov eax, [ecx+0x4] */
            ii(0x1018_d678, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d67a, 2); if(jz(0x1018_d68d, 0x11)) goto l_0x1018_d68d; /* jz 0x1018d68d */
            ii(0x1018_d67c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d67e, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1018_d683, 2); neg(edx);                               /* neg edx */
            ii(0x1018_d685, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1018_d688, 5); call(Definitions.sys_lseek, -0x1_04f6); /* call 0x1017d197 */
        l_0x1018_d68d:
            ii(0x1018_d68d, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_d690, 2); if(jnz(0x1018_d69d, 0xb)) goto l_0x1018_d69d; /* jnz 0x1018d69d */
            ii(0x1018_d692, 3); mov(bl, memb[ds, ecx + 12]);            /* mov bl, [ecx+0xc] */
            ii(0x1018_d695, 3); or(bl, 0x20);                           /* or bl, 0x20 */
            ii(0x1018_d698, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_d69a, 3); mov(memb[ds, ecx + 12], bl);            /* mov [ecx+0xc], bl */
        l_0x1018_d69d:
            ii(0x1018_d69d, 3); mov(eax, memd[ds, ecx + 8]);            /* mov eax, [ecx+0x8] */
            ii(0x1018_d6a0, 7); mov(memd[ds, ecx + 4], 0);              /* mov dword [ecx+0x4], 0x0 */
            ii(0x1018_d6a7, 2); mov(memd[ds, ecx], eax);                /* mov [ecx], eax */
            ii(0x1018_d6a9, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_d6ab, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_d6ac, 1); pop(edi);                               /* pop edi */
            ii(0x1018_d6ad, 1); pop(esi);                               /* pop esi */
            ii(0x1018_d6ae, 1); pop(edx);                               /* pop edx */
            ii(0x1018_d6af, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_d6b0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_d6b1, 1); ret();                                  /* ret */
        }
    }
}
