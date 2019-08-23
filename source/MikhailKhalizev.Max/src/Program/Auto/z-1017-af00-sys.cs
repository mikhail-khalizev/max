using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_af00-a1dc91c5")]
        public void /* sys */ Method_1017_af00()
        {
            ii(0x1017_af00, 1); push(ebp);                              /* push ebp */
            ii(0x1017_af01, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_af03, 1); push(esi);                              /* push esi */
            ii(0x1017_af04, 1); push(edi);                              /* push edi */
            ii(0x1017_af05, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_af07, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1017_af09, 3); mov(ebx, memd[ss, ebp + 0x2c]);         /* mov ebx, [ebp+0x2c] */
            ii(0x1017_af0c, 3); mov(edx, memd[ss, ebp + 0x30]);         /* mov edx, [ebp+0x30] */
            ii(0x1017_af0f, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1017_af11, 3); mov(edx, memd[ss, ebp + 0x34]);         /* mov edx, [ebp+0x34] */
            ii(0x1017_af14, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x1017_af17, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x1017_af1c, 7); cmp(memd[ss, ebp + 0x28], 0x168);       /* cmp dword [ebp+0x28], 0x168 */
            ii(0x1017_af23, 2); if(jnz(0x1017_af2a, 0x5)) goto l_0x1017_af2a; /* jnz 0x1017af2a */
            ii(0x1017_af25, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
        l_0x1017_af2a:
            ii(0x1017_af2a, 6); cmp(ebx, 0x15e);                        /* cmp ebx, 0x15e */
            ii(0x1017_af30, 2); if(jz(0x1017_af3a, 0x8)) goto l_0x1017_af3a; /* jz 0x1017af3a */
            ii(0x1017_af32, 6); cmp(ebx, 0xaf);                         /* cmp ebx, 0xaf */
            ii(0x1017_af38, 2); if(jnz(0x1017_af3f, 0x5)) goto l_0x1017_af3f; /* jnz 0x1017af3f */
        l_0x1017_af3a:
            ii(0x1017_af3a, 3); or(dl, 0x80);                           /* or dl, 0x80 */
            ii(0x1017_af3d, 2); jmp(0x1017_af57, 0x18); goto l_0x1017_af57; /* jmp 0x1017af57 */
        l_0x1017_af3f:
            ii(0x1017_af3f, 6); cmp(ebx, 0x1e0);                        /* cmp ebx, 0x1e0 */
            ii(0x1017_af45, 2); if(jz(0x1017_af4f, 0x8)) goto l_0x1017_af4f; /* jz 0x1017af4f */
            ii(0x1017_af47, 6); cmp(ebx, 0xf0);                         /* cmp ebx, 0xf0 */
            ii(0x1017_af4d, 2); if(jnz(0x1017_af54, 0x5)) goto l_0x1017_af54; /* jnz 0x1017af54 */
        l_0x1017_af4f:
            ii(0x1017_af4f, 3); or(dl, 0xc0);                           /* or dl, 0xc0 */
            ii(0x1017_af52, 2); jmp(0x1017_af57, 0x3); goto l_0x1017_af57; /* jmp 0x1017af57 */
        l_0x1017_af54:
            ii(0x1017_af54, 3); or(dl, 0x40);                           /* or dl, 0x40 */
        l_0x1017_af57:
            ii(0x1017_af57, 3); mov(memd[ds, eax + 0x8], edx);          /* mov [eax+0x8], edx */
            ii(0x1017_af5a, 4); cmp(memd[ss, ebp + 0x18], 0);           /* cmp dword [ebp+0x18], 0x0 */
            ii(0x1017_af5e, 2); if(jnz(0x1017_af67, 0x7)) goto l_0x1017_af67; /* jnz 0x1017af67 */
            ii(0x1017_af60, 7); mov(memd[ss, ebp + 0x18], 0x70);        /* mov dword [ebp+0x18], 0x70 */
        l_0x1017_af67:
            ii(0x1017_af67, 4); cmp(memd[ss, ebp + 0x1c], 0);           /* cmp dword [ebp+0x1c], 0x0 */
            ii(0x1017_af6b, 2); if(jnz(0x1017_af74, 0x7)) goto l_0x1017_af74; /* jnz 0x1017af74 */
            ii(0x1017_af6d, 7); mov(memd[ss, ebp + 0x1c], 0x214);       /* mov dword [ebp+0x1c], 0x214 */
        l_0x1017_af74:
            ii(0x1017_af74, 7); mov(memd[ds, eax + 0x24], 0);           /* mov dword [eax+0x24], 0x0 */
            ii(0x1017_af7b, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x1017_af7e, 7); mov(memd[ds, eax + 0x28], 0);           /* mov dword [eax+0x28], 0x0 */
            ii(0x1017_af85, 3); mov(memd[ds, eax + 0xc], edx);          /* mov [eax+0xc], edx */
            ii(0x1017_af88, 3); mov(edx, memd[ss, ebp + 0xc]);          /* mov edx, [ebp+0xc] */
            ii(0x1017_af8b, 7); mov(memd[ds, eax + 0x44], 0x3ff);       /* mov dword [eax+0x44], 0x3ff */
            ii(0x1017_af92, 3); shr(edx, 0x2);                          /* shr edx, 0x2 */
            ii(0x1017_af95, 7); mov(memd[ds, eax + 0x48], 0);           /* mov dword [eax+0x48], 0x0 */
            ii(0x1017_af9c, 1); dec(edx);                               /* dec edx */
            ii(0x1017_af9d, 3); mov(memd[ds, eax + 0x10], edx);         /* mov [eax+0x10], edx */
            ii(0x1017_afa0, 2); add(edx, esi);                          /* add edx, esi */
            ii(0x1017_afa2, 3); mov(memd[ds, eax + 0x14], edx);         /* mov [eax+0x14], edx */
            ii(0x1017_afa5, 3); mov(edx, memd[ss, ebp + 0x20]);         /* mov edx, [ebp+0x20] */
            ii(0x1017_afa8, 3); mov(memd[ds, eax + 0x18], edx);         /* mov [eax+0x18], edx */
            ii(0x1017_afab, 3); add(edx, 0xc);                          /* add edx, 0xc */
            ii(0x1017_afae, 3); mov(memd[ds, eax + 0x1c], edx);         /* mov [eax+0x1c], edx */
            ii(0x1017_afb1, 3); mov(edx, memd[ds, eax + 0xc]);          /* mov edx, [eax+0xc] */
            ii(0x1017_afb4, 7); mov(memd[ds, eax + 0x4c], 0);           /* mov dword [eax+0x4c], 0x0 */
            ii(0x1017_afbb, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x1017_afbe, 7); mov(memd[ds, eax + 0x50], 0);           /* mov dword [eax+0x50], 0x0 */
            ii(0x1017_afc5, 2); sub(edx, edi);                          /* sub edx, edi */
            ii(0x1017_afc7, 3); mov(memd[ds, eax + 0x20], edx);         /* mov [eax+0x20], edx */
            ii(0x1017_afca, 3); mov(edx, memd[ss, ebp + 0x1c]);         /* mov edx, [ebp+0x1c] */
            ii(0x1017_afcd, 3); mov(memd[ds, eax + 0x2c], edx);         /* mov [eax+0x2c], edx */
            ii(0x1017_afd0, 3); mov(edx, memd[ss, ebp + 0x10]);         /* mov edx, [ebp+0x10] */
            ii(0x1017_afd3, 7); mov(memd[ds, eax + 0x54], 0);           /* mov dword [eax+0x54], 0x0 */
            ii(0x1017_afda, 1); dec(edx);                               /* dec edx */
            ii(0x1017_afdb, 3); mov(esi, memd[ss, ebp + 0x8]);          /* mov esi, [ebp+0x8] */
            ii(0x1017_afde, 3); mov(memd[ds, eax + 0x30], edx);         /* mov [eax+0x30], edx */
            ii(0x1017_afe1, 2); add(edx, esi);                          /* add edx, esi */
            ii(0x1017_afe3, 3); mov(memd[ds, eax + 0x34], edx);         /* mov [eax+0x34], edx */
            ii(0x1017_afe6, 3); mov(edx, memd[ss, ebp + 0x24]);         /* mov edx, [ebp+0x24] */
            ii(0x1017_afe9, 3); mov(memd[ds, eax + 0x38], edx);         /* mov [eax+0x38], edx */
            ii(0x1017_afec, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1017_afef, 3); mov(memd[ds, eax + 0x3c], edx);         /* mov [eax+0x3c], edx */
            ii(0x1017_aff2, 3); mov(edx, memd[ds, eax + 0x2c]);         /* mov edx, [eax+0x2c] */
            ii(0x1017_aff5, 7); mov(memd[ds, eax + 0x58], 0);           /* mov dword [eax+0x58], 0x0 */
            ii(0x1017_affc, 3); sub(edx, 0x2);                          /* sub edx, 0x2 */
            ii(0x1017_afff, 7); mov(memd[ds, eax + 0x60], 0x1);         /* mov dword [eax+0x60], 0x1 */
            ii(0x1017_b006, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1017_b008, 3); mov(memd[ds, eax + 0x40], edx);         /* mov [eax+0x40], edx */
            ii(0x1017_b00b, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1017_b00e, 7); mov(memd[ds, eax + 0x64], 0);           /* mov dword [eax+0x64], 0x0 */
            ii(0x1017_b015, 3); shr(edx, 0x2);                          /* shr edx, 0x2 */
            ii(0x1017_b018, 3); mov(memd[ds, eax + 0x5c], edx);         /* mov [eax+0x5c], edx */
            ii(0x1017_b01b, 6); cmp(ebx, 0xf0);                         /* cmp ebx, 0xf0 */
            ii(0x1017_b021, 3); setbe(dl);                              /* setbe dl */
            ii(0x1017_b024, 7); mov(memd[ds, eax + 0x6c], 0x1);         /* mov dword [eax+0x6c], 0x1 */
            ii(0x1017_b02b, 7); mov(memd[ds, eax + 0x70], 0x1);         /* mov dword [eax+0x70], 0x1 */
            ii(0x1017_b032, 7); mov(memd[ds, eax + 0x74], 0x1);         /* mov dword [eax+0x74], 0x1 */
            ii(0x1017_b039, 7); mov(memd[ds, eax + 0x78], 0);           /* mov dword [eax+0x78], 0x0 */
            ii(0x1017_b040, 7); mov(memd[ds, eax + 0x7c], 0);           /* mov dword [eax+0x7c], 0x0 */
            ii(0x1017_b047, 10); mov(memd[ds, eax + 0x80], 0);          /* mov dword [eax+0x80], 0x0 */
            ii(0x1017_b051, 10); mov(memd[ds, eax + 0x84], 0x1);        /* mov dword [eax+0x84], 0x1 */
            ii(0x1017_b05b, 10); mov(memd[ds, eax + 0x88], 0x1);        /* mov dword [eax+0x88], 0x1 */
            ii(0x1017_b065, 10); mov(memd[ds, eax + 0x8c], 0x31);       /* mov dword [eax+0x8c], 0x31 */
            ii(0x1017_b06f, 10); mov(memd[ds, eax + 0x90], 0);          /* mov dword [eax+0x90], 0x0 */
            ii(0x1017_b079, 10); mov(memd[ds, eax + 0x94], 0);          /* mov dword [eax+0x94], 0x0 */
            ii(0x1017_b083, 10); mov(memd[ds, eax + 0x98], 0);          /* mov dword [eax+0x98], 0x0 */
            ii(0x1017_b08d, 10); mov(memd[ds, eax + 0x9c], 0);          /* mov dword [eax+0x9c], 0x0 */
            ii(0x1017_b097, 10); mov(memd[ds, eax + 0xa0], 0);          /* mov dword [eax+0xa0], 0x0 */
            ii(0x1017_b0a1, 10); mov(memd[ds, eax + 0xa4], 0x1);        /* mov dword [eax+0xa4], 0x1 */
            ii(0x1017_b0ab, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_b0b1, 10); mov(memd[ds, eax + 0xa8], 0x1);        /* mov dword [eax+0xa8], 0x1 */
            ii(0x1017_b0bb, 3); mov(memd[ds, eax + 0x68], edx);         /* mov [eax+0x68], edx */
            ii(0x1017_b0be, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_b0c1, 1); pop(edi);                               /* pop edi */
            ii(0x1017_b0c2, 1); pop(esi);                               /* pop esi */
            ii(0x1017_b0c3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_b0c4, 3); ret(0x30);                              /* ret 0x30 */
        }
    }
}
