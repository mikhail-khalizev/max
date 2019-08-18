using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_b52e-89240685")]
        public void Method_1028_b52e()
        {
            ii(0x1028_b52e, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b52f, 1); pushd(es);                              /* push es */
            ii(0x1028_b530, 2); pushd(fs);                              /* push fs */
            ii(0x1028_b532, 2); pushd(gs);                              /* push gs */
            ii(0x1028_b534, 1); pushad();                               /* pushad */
            ii(0x1028_b535, 4); mov(ax, 0x2e8);                         /* mov ax, 0x2e8 */
            ii(0x1028_b539, 3); mov(ds, ax);                            /* mov ds, ax */
            ii(0x1028_b53c, 7); cmp(memd_a32[ds, 0x136a], 0);           /* cmp dword [0x136a], 0x0 */
            ii(0x1028_b543, 6); if(jnzd(0x1028_baf1, 0x5a8)) goto l_0x1028_baf1; /* jnz 0x1028baf1 */
            ii(0x1028_b549, 6); inc(memd_a32[ds, 0x136a]);              /* inc dword [0x136a] */
            ii(0x1028_b54f, 7); mov(memw_a32[ds, 0x139e], es);          /* mov [0x139e], es */
            ii(0x1028_b556, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b557, 1); pushd(es);                              /* push es */
            ii(0x1028_b558, 1); pushd(esi);                             /* push esi */
            ii(0x1028_b559, 1); pushd(edi);                             /* push edi */
            ii(0x1028_b55a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1028_b55b, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b55c, 2); popd(fs);                               /* pop fs */
            ii(0x1028_b55e, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1028_b560, 5); mov(esi, 0x3d0);                        /* mov esi, 0x3d0 */
            ii(0x1028_b565, 5); mov(ebx, 0x1228);                       /* mov ebx, 0x1228 */
            ii(0x1028_b56a, 10); mov(memd_a32[ds, 0x12a8], 0);          /* mov dword [0x12a8], 0x0 */
            ii(0x1028_b574, 5); mov(ecx, 0x20);                         /* mov ecx, 0x20 */
        l_0x1028_b579:
            ii(0x1028_b579, 6); test(memw_a32[ds, esi + 0x30], 0x8000); /* test word [esi+0x30], 0x8000 */
            ii(0x1028_b57f, 2); if(jzd(0x1028_b594, 0x13)) goto l_0x1028_b594; /* jz 0x1028b594 */
            ii(0x1028_b581, 6); test(memw_a32[ds, esi + 0x30], 0x1000); /* test word [esi+0x30], 0x1000 */
            ii(0x1028_b587, 2); if(jnzd(0x1028_b594, 0xb)) goto l_0x1028_b594; /* jnz 0x1028b594 */
            ii(0x1028_b589, 2); mov(memd_a32[ds, ebx], esi);            /* mov [ebx], esi */
            ii(0x1028_b58b, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1028_b58e, 6); inc(memd_a32[ds, 0x12a8]);              /* inc dword [0x12a8] */
        l_0x1028_b594:
            ii(0x1028_b594, 3); add(esi, 0x6c);                         /* add esi, 0x6c */
            ii(0x1028_b597, 1); dec(ecx);                               /* dec ecx */
            ii(0x1028_b598, 2); if(jnzd(0x1028_b579, -0x21)) goto l_0x1028_b579; /* jnz 0x1028b579 */
            ii(0x1028_b59a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1028_b59c, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1028_b5a1, 2); xor(al, al);                            /* xor al, al */
            ii(0x1028_b5a3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_b5a4, 2); jmpd(0x1028_b5a6, 0); goto l_0x1028_b5a6; /* jmp 0x1028b5a6 */
        l_0x1028_b5a6:
            ii(0x1028_b5a6, 7); movzx(edx, memw_a32[ds, 0x14be]);       /* movzx edx, word [0x14be] */
            ii(0x1028_b5ad, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_b5ae, 2); jmpd(0x1028_b5b0, 0); goto l_0x1028_b5b0; /* jmp 0x1028b5b0 */
        l_0x1028_b5b0:
            ii(0x1028_b5b0, 2); xchg(ah, al);                           /* xchg ah, al */
            ii(0x1028_b5b2, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_b5b3, 2); jmpd(0x1028_b5b5, 0); goto l_0x1028_b5b5; /* jmp 0x1028b5b5 */
        l_0x1028_b5b5:
            ii(0x1028_b5b5, 2); xchg(ah, al);                           /* xchg ah, al */
            ii(0x1028_b5b7, 1); inc(eax);                               /* inc eax */
            ii(0x1028_b5b8, 3); cmp(edx, 0x7);                          /* cmp edx, 0x7 */
            ii(0x1028_b5bb, 2); if(jbed(0x1028_b5bf, 0x2)) goto l_0x1028_b5bf; /* jbe 0x1028b5bf */
            ii(0x1028_b5bd, 2); add(eax, eax);                          /* add eax, eax */
        l_0x1028_b5bf:
            ii(0x1028_b5bf, 6); cmp(eax, memd_a32[ds, 0x1366]);         /* cmp eax, [0x1366] */
            ii(0x1028_b5c5, 2); if(jbed(0x1028_b5e8, 0x21)) goto l_0x1028_b5e8; /* jbe 0x1028b5e8 */
            ii(0x1028_b5c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1028_b5c9, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1028_b5ce, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_b5cf, 2); jmpd(0x1028_b5d1, 0); goto l_0x1028_b5d1; /* jmp 0x1028b5d1 */
        l_0x1028_b5d1:
            ii(0x1028_b5d1, 5); mov(eax, memd_a32[ds, 0x1366]);         /* mov eax, [0x1366] */
            ii(0x1028_b5d6, 1); dec(eax);                               /* dec eax */
            ii(0x1028_b5d7, 7); movzx(edx, memw_a32[ds, 0x14be]);       /* movzx edx, word [0x14be] */
            ii(0x1028_b5de, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_b5df, 2); jmpd(0x1028_b5e1, 0); goto l_0x1028_b5e1; /* jmp 0x1028b5e1 */
        l_0x1028_b5e1:
            ii(0x1028_b5e1, 2); xchg(ah, al);                           /* xchg ah, al */
            ii(0x1028_b5e3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_b5e4, 2); jmpd(0x1028_b5e6, 0); goto l_0x1028_b5e6; /* jmp 0x1028b5e6 */
        l_0x1028_b5e6:
            ii(0x1028_b5e6, 2); xchg(ah, al);                           /* xchg ah, al */
        l_0x1028_b5e8:
            ii(0x1028_b5e8, 6); mov(ebx, memd_a32[ds, 0x1366]);         /* mov ebx, [0x1366] */
            ii(0x1028_b5ee, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1028_b5f0, 6); and(ebx, 0xfffc);                       /* and ebx, 0xfffc */
            ii(0x1028_b5f6, 2); or(ebx, ebx);                           /* or ebx, ebx */
            ii(0x1028_b5f8, 2); if(jnzd(0x1028_b5fd, 0x3)) goto l_0x1028_b5fd; /* jnz 0x1028b5fd */
            ii(0x1028_b5fa, 3); add(ebx, 0x20);                         /* add ebx, 0x20 */
        l_0x1028_b5fd:
            ii(0x1028_b5fd, 6); mov(memd_a32[ds, 0x1330], ebx);         /* mov [0x1330], ebx */
            ii(0x1028_b603, 6); sub(ebx, memd_a32[ds, 0x1354]);         /* sub ebx, [0x1354] */
            ii(0x1028_b609, 6); if(jaed(0x1028_b621, 0x12)) goto l_0x1028_b621; /* jae 0x1028b621 */
            ii(0x1028_b60f, 6); mov(ebx, memd_a32[ds, 0x1366]);         /* mov ebx, [0x1366] */
            ii(0x1028_b615, 6); sub(ebx, memd_a32[ds, 0x1354]);         /* sub ebx, [0x1354] */
            ii(0x1028_b61b, 6); add(ebx, memd_a32[ds, 0x1330]);         /* add ebx, [0x1330] */
        l_0x1028_b621:
            ii(0x1028_b621, 6); mov(memd_a32[ds, 0x1338], ebx);         /* mov [0x1338], ebx */
            ii(0x1028_b627, 6); mov(memd_a32[ds, 0x133c], ebx);         /* mov [0x133c], ebx */
            ii(0x1028_b62d, 3); shr(ebx, 0x3);                          /* shr ebx, 0x3 */
            ii(0x1028_b630, 6); and(ebx, 0xfffc);                       /* and ebx, 0xfffc */
            ii(0x1028_b636, 6); add(memd_a32[ds, 0x133c], ebx);         /* add [0x133c], ebx */
            ii(0x1028_b63c, 5); mov(eax, memd_a32[ds, 0x1330]);         /* mov eax, [0x1330] */
            ii(0x1028_b641, 5); add(eax, 0x400);                        /* add eax, 0x400 */
            ii(0x1028_b646, 6); cmp(eax, memd_a32[ds, 0x1366]);         /* cmp eax, [0x1366] */
            ii(0x1028_b64c, 2); if(jbed(0x1028_b654, 0x6)) goto l_0x1028_b654; /* jbe 0x1028b654 */
            ii(0x1028_b64e, 6); sub(eax, memd_a32[ds, 0x1366]);         /* sub eax, [0x1366] */
        l_0x1028_b654:
            ii(0x1028_b654, 5); mov(memd_a32[ds, 0x135e], eax);         /* mov [0x135e], eax */
            ii(0x1028_b659, 7); cmp(memd_a32[ds, 0x132c], 0);           /* cmp dword [0x132c], 0x0 */
            ii(0x1028_b660, 6); if(jzd(0x1028_b6ff, 0x99)) goto l_0x1028_b6ff; /* jz 0x1028b6ff */
            ii(0x1028_b666, 5); mov(eax, memd_a32[ds, 0x1338]);         /* mov eax, [0x1338] */
            ii(0x1028_b66b, 5); mov(ebx, 0x12ac);                       /* mov ebx, 0x12ac */
            ii(0x1028_b670, 6); mov(ecx, memd_a32[ds, 0x132c]);         /* mov ecx, [0x132c] */
        l_0x1028_b676:
            ii(0x1028_b676, 2); mov(esi, memd_a32[ds, ebx]);            /* mov esi, [ebx] */
            ii(0x1028_b678, 4); sub(memw_a32[ds, esi + 0x24], ax);      /* sub [esi+0x24], ax */
            ii(0x1028_b67c, 2); if(jaed(0x1028_b6f5, 0x77)) goto l_0x1028_b6f5; /* jae 0x1028b6f5 */
            ii(0x1028_b67e, 6); mov(memw_a32[ds, esi + 0x24], 0);       /* mov word [esi+0x24], 0x0 */
            ii(0x1028_b684, 6); and(memw_a32[ds, esi + 0x30], 0x6fff);  /* and word [esi+0x30], 0x6fff */
            ii(0x1028_b68a, 4); cmp(memd_a32[ds, esi + 0x3c], 0);       /* cmp dword [esi+0x3c], 0x0 */
            ii(0x1028_b68e, 2); if(jzd(0x1028_b6db, 0x4b)) goto l_0x1028_b6db; /* jz 0x1028b6db */
            ii(0x1028_b690, 6); test(memw_a32[ds, esi + 0x30], 0x2);    /* test word [esi+0x30], 0x2 */
            ii(0x1028_b696, 2); if(jnzd(0x1028_b6db, 0x43)) goto l_0x1028_b6db; /* jnz 0x1028b6db */
            ii(0x1028_b698, 1); pushad();                               /* pushad */
            ii(0x1028_b699, 2); pushd(gs);                              /* push gs */
            ii(0x1028_b69b, 1); pushd(es);                              /* push es */
            ii(0x1028_b69c, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b69d, 7); mov(es, memw_a32[ds, 0x139e]);          /* mov es, [0x139e] */
            ii(0x1028_b6a4, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b6a5, 2); popd(gs);                               /* pop gs */
            ii(0x1028_b6a7, 8); mov(ds, memw_a32[gs, 0x136e]);          /* mov ds, [gs:0x136e] */
            ii(0x1028_b6af, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1028_b6b1, 5); sub(eax, 0x3d0);                        /* sub eax, 0x3d0 */
            ii(0x1028_b6b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1028_b6b8, 4); mov(bx, 0x6c);                          /* mov bx, 0x6c */
            ii(0x1028_b6bc, 3); div(bx);                                /* div bx */
            ii(0x1028_b6bf, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b6c0, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1028_b6c5, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b6c6, 8); movzx(eax, memw_a32[gs, 0x1388]);       /* movzx eax, word [gs:0x1388] */
            ii(0x1028_b6ce, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b6cf, 4); calld_a32_far_ind(gs, esi + 0x3c);      /* call far dword [gs:esi+0x3c] */
            ii(0x1028_b6d3, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1028_b6d6, 1); popd(ds);                               /* pop ds */
            ii(0x1028_b6d7, 1); popd(es);                               /* pop es */
            ii(0x1028_b6d8, 2); popd(gs);                               /* pop gs */
            ii(0x1028_b6da, 1); popad();                                /* popad */
        l_0x1028_b6db:
            ii(0x1028_b6db, 1); pushd(es);                              /* push es */
            ii(0x1028_b6dc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1028_b6dd, 1); pushd(esi);                             /* push esi */
            ii(0x1028_b6de, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b6df, 1); popd(es);                               /* pop es */
            ii(0x1028_b6e0, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1028_b6e2, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1028_b6e4, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1028_b6e7, 1); cld();                                  /* cld */
            ii(0x1028_b6e8, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1028_b6ea, 1); popd(esi);                              /* pop esi */
            ii(0x1028_b6eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1028_b6ec, 1); popd(es);                               /* pop es */
            ii(0x1028_b6ed, 6); dec(memd_a32[ds, 0x132c]);              /* dec dword [0x132c] */
            ii(0x1028_b6f3, 2); jmpd(0x1028_b6f8, 0x3); goto l_0x1028_b6f8; /* jmp 0x1028b6f8 */
        l_0x1028_b6f5:
            ii(0x1028_b6f5, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
        l_0x1028_b6f8:
            ii(0x1028_b6f8, 1); dec(ecx);                               /* dec ecx */
            ii(0x1028_b6f9, 6); if(jnzd(0x1028_b676, -0x89)) goto l_0x1028_b676; /* jnz 0x1028b676 */
        l_0x1028_b6ff:
            ii(0x1028_b6ff, 7); mov(es, memw_a32[ds, 0x135c]);          /* mov es, [0x135c] */
            ii(0x1028_b706, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1028_b708, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_b70a, 6); mov(edi, memd_a32[ds, 0x1354]);         /* mov edi, [0x1354] */
            ii(0x1028_b710, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1028_b712, 6); mov(ecx, memd_a32[ds, 0x1330]);         /* mov ecx, [0x1330] */
            ii(0x1028_b718, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1028_b71a, 2); if(jbd(0x1028_b730, 0x14)) goto l_0x1028_b730; /* jb 0x1028b730 */
            ii(0x1028_b71c, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1028_b71e, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_b721, 1); cld();                                  /* cld */
            ii(0x1028_b722, 2); rep_a32(() => stosd_a32());             /* rep stosd */
            ii(0x1028_b724, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1028_b726, 3); and(ecx, 0x3);                          /* and ecx, 0x3 */
            ii(0x1028_b729, 2); rep_a32(() => stosb_a32());             /* rep stosb */
            ii(0x1028_b72b, 2); jmpd(0x1028_b75d, 0x30); goto l_0x1028_b75d; /* jmp 0x1028b75d */
        //    ii(0x1028_b72d, 1); nop();                                  /* nop */
        //    ii(0x1028_b72e, 1); nop();                                  /* nop */
        //    ii(0x1028_b72f, 1); nop();                                  /* nop */
        l_0x1028_b730:
            ii(0x1028_b730, 6); mov(ecx, memd_a32[ds, 0x1366]);         /* mov ecx, [0x1366] */
            ii(0x1028_b736, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1028_b738, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1028_b73a, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_b73d, 1); cld();                                  /* cld */
            ii(0x1028_b73e, 2); rep_a32(() => stosd_a32());             /* rep stosd */
            ii(0x1028_b740, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1028_b742, 3); and(ecx, 0x3);                          /* and ecx, 0x3 */
            ii(0x1028_b745, 2); rep_a32(() => stosb_a32());             /* rep stosb */
            ii(0x1028_b747, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1028_b749, 6); mov(ecx, memd_a32[ds, 0x1330]);         /* mov ecx, [0x1330] */
            ii(0x1028_b74f, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1028_b751, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_b754, 2); rep_a32(() => stosd_a32());             /* rep stosd */
            ii(0x1028_b756, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1028_b758, 3); and(ecx, 0x3);                          /* and ecx, 0x3 */
            ii(0x1028_b75b, 2); rep_a32(() => stosb_a32());             /* rep stosb */
        l_0x1028_b75d:
            ii(0x1028_b75d, 7); cmp(memd_a32[ds, 0x12a8], 0);           /* cmp dword [0x12a8], 0x0 */
            ii(0x1028_b764, 6); if(jzd(0x1028_badc, 0x372)) goto l_0x1028_badc; /* jz 0x1028badc */
            ii(0x1028_b76a, 7); mov(es, memw_a32[ds, 0x135c]);          /* mov es, [0x135c] */
            ii(0x1028_b771, 5); mov(ebx, 0x1228);                       /* mov ebx, 0x1228 */
        l_0x1028_b776:
            ii(0x1028_b776, 6); mov(memd_a32[ds, 0x1362], ebx);         /* mov [0x1362], ebx */
            ii(0x1028_b77c, 2); mov(esi, memd_a32[ds, ebx]);            /* mov esi, [ebx] */
            ii(0x1028_b77e, 4); movzx(eax, memw_a32[ds, esi + 0x30]);   /* movzx eax, word [esi+0x30] */
            ii(0x1028_b782, 5); and(eax, 0x7b0);                        /* and eax, 0x7b0 */
            ii(0x1028_b787, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x1028_b78a, 3); or(al, memb_a32[ds, esi + 0x36]);       /* or al, [esi+0x36] */
            ii(0x1028_b78d, 10); mov(memd_a32[ds, 0x13a4], 0);          /* mov dword [0x13a4], 0x0 */
            ii(0x1028_b797, 10); mov(memd_a32[ds, 0x13a0], 0);          /* mov dword [0x13a0], 0x0 */
            ii(0x1028_b7a1, 5); mov(edi, 0x13a8);                       /* mov edi, 0x13a8 */
            ii(0x1028_b7a6, 5); mov(ecx, 0x1f);                         /* mov ecx, 0x1f */
        l_0x1028_b7ab:
            ii(0x1028_b7ab, 3); cmp(memd_a32[ds, edi], 0);              /* cmp dword [edi], 0x0 */
            ii(0x1028_b7ae, 2); if(jzd(0x1028_b7c0, 0x10)) goto l_0x1028_b7c0; /* jz 0x1028b7c0 */
            ii(0x1028_b7b0, 2); cmp(memd_a32[ds, edi], eax);            /* cmp [edi], eax */
            ii(0x1028_b7b2, 2); if(jzd(0x1028_b7c8, 0x14)) goto l_0x1028_b7c8; /* jz 0x1028b7c8 */
            ii(0x1028_b7b4, 3); add(edi, 0x4);                          /* add edi, 0x4 */
            ii(0x1028_b7b7, 6); inc(memd_a32[ds, 0x13a4]);              /* inc dword [0x13a4] */
            ii(0x1028_b7bd, 1); dec(ecx);                               /* dec ecx */
            ii(0x1028_b7be, 2); if(jnzd(0x1028_b7ab, -0x15)) goto l_0x1028_b7ab; /* jnz 0x1028b7ab */
        l_0x1028_b7c0:
            ii(0x1028_b7c0, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1028_b7c2, 6); inc(memd_a32[ds, 0x13a0]);              /* inc dword [0x13a0] */
        l_0x1028_b7c8:
            ii(0x1028_b7c8, 5); mov(edx, 0x2104);                       /* mov edx, 0x2104 */
            ii(0x1028_b7cd, 5); mov(eax, memd_a32[ds, 0x13a4]);         /* mov eax, [0x13a4] */
            ii(0x1028_b7d2, 5); mov(ebx, 0x200);                        /* mov ebx, 0x200 */
            ii(0x1028_b7d7, 2); xchg(edx, ecx);                         /* xchg edx, ecx */
            ii(0x1028_b7d9, 3); mul(bx);                                /* mul bx */
            ii(0x1028_b7dc, 2); xchg(edx, ecx);                         /* xchg edx, ecx */
            ii(0x1028_b7de, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1028_b7e0, 6); mov(memd_a32[ds, 0x1374], edx);         /* mov [0x1374], edx */
            ii(0x1028_b7e6, 7); cmp(memd_a32[ds, 0x13a0], 0);           /* cmp dword [0x13a0], 0x0 */
            ii(0x1028_b7ed, 2); if(jzd(0x1028_b7f9, 0xa)) goto l_0x1028_b7f9; /* jz 0x1028b7f9 */
            ii(0x1028_b7ef, 5); calld(0x1028_bcf9, 0x505);              /* call 0x1028bcf9 */
            ii(0x1028_b7f4, 5); calld(0x1028_c020, 0x827);              /* call 0x1028c020 */
        l_0x1028_b7f9:
            ii(0x1028_b7f9, 6); test(memw_a32[ds, esi + 0x30], 0x2000); /* test word [esi+0x30], 0x2000 */
            ii(0x1028_b7ff, 2); if(jzd(0x1028_b810, 0xf)) goto l_0x1028_b810; /* jz 0x1028b810 */
            ii(0x1028_b801, 6); and(memw_a32[ds, esi + 0x30], 0xdfff);  /* and word [esi+0x30], 0xdfff */
            ii(0x1028_b807, 5); mov(eax, memd_a32[ds, 0x135e]);         /* mov eax, [0x135e] */
            ii(0x1028_b80c, 4); mov(memw_a32[ds, esi + 0x3a], ax);      /* mov [esi+0x3a], ax */
        l_0x1028_b810:
            ii(0x1028_b810, 4); movzx(eax, memw_a32[ds, esi + 0x3a]);   /* movzx eax, word [esi+0x3a] */
            ii(0x1028_b814, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1028_b816, 6); mov(edx, memd_a32[ds, 0x133c]);         /* mov edx, [0x133c] */
            ii(0x1028_b81c, 6); mov(memd_a32[ds, 0x1340], edx);         /* mov [0x1340], edx */
            ii(0x1028_b822, 10); mov(memd_a32[ds, 0x1348], 0);          /* mov dword [0x1348], 0x0 */
            ii(0x1028_b82c, 6); add(eax, memd_a32[ds, 0x133c]);         /* add eax, [0x133c] */
            ii(0x1028_b832, 6); cmp(eax, memd_a32[ds, 0x1366]);         /* cmp eax, [0x1366] */
            ii(0x1028_b838, 6); if(jbed(0x1028_b853, 0x15)) goto l_0x1028_b853; /* jbe 0x1028b853 */
            ii(0x1028_b83e, 6); mov(edx, memd_a32[ds, 0x1366]);         /* mov edx, [0x1366] */
            ii(0x1028_b844, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1028_b846, 5); mov(memd_a32[ds, 0x1348], eax);         /* mov [0x1348], eax */
            ii(0x1028_b84b, 2); sub(edx, edi);                          /* sub edx, edi */
            ii(0x1028_b84d, 6); mov(memd_a32[ds, 0x1340], edx);         /* mov [0x1340], edx */
        l_0x1028_b853:
            ii(0x1028_b853, 5); cmp(memw_a32[ds, esi + 0x1e], 0);       /* cmp word [esi+0x1e], 0x0 */
            ii(0x1028_b858, 2); if(jnzd(0x1028_b8bc, 0x62)) goto l_0x1028_b8bc; /* jnz 0x1028b8bc */
            ii(0x1028_b85a, 4); movzx(ebx, memw_a32[ds, esi + 0x1c]);   /* movzx ebx, word [esi+0x1c] */
            ii(0x1028_b85e, 5); cmp(memw_a32[ds, esi + 0x36], 0x3);     /* cmp word [esi+0x36], 0x3 */
            ii(0x1028_b863, 2); if(jzd(0x1028_b867, 0x2)) goto l_0x1028_b867; /* jz 0x1028b867 */
            ii(0x1028_b865, 2); add(ebx, ebx);                          /* add ebx, ebx */
        l_0x1028_b867:
            ii(0x1028_b867, 6); test(memw_a32[ds, esi + 0x30], 0x20);   /* test word [esi+0x30], 0x20 */
            ii(0x1028_b86d, 2); if(jzd(0x1028_b871, 0x2)) goto l_0x1028_b871; /* jz 0x1028b871 */
            ii(0x1028_b86f, 2); shl(ebx, 0x1);                          /* shl ebx, 1 */
        l_0x1028_b871:
            ii(0x1028_b871, 6); test(memw_a32[ds, esi + 0x30], 0x400);  /* test word [esi+0x30], 0x400 */
            ii(0x1028_b877, 2); if(jzd(0x1028_b88e, 0x15)) goto l_0x1028_b88e; /* jz 0x1028b88e */
            ii(0x1028_b879, 1); pushd(edx);                             /* push edx */
            ii(0x1028_b87a, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b87b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1028_b87d, 3); mov(ebx, memd_a32[ds, esi + 0x44]);     /* mov ebx, [esi+0x44] */
            ii(0x1028_b880, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1028_b882, 3); shr(edx, 0x10);                         /* shr edx, 0x10 */
            ii(0x1028_b885, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1028_b888, 2); div(ebx);                               /* div ebx */
            ii(0x1028_b88a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1028_b88c, 1); popd(eax);                              /* pop eax */
            ii(0x1028_b88d, 1); popd(edx);                              /* pop edx */
        l_0x1028_b88e:
            ii(0x1028_b88e, 6); cmp(ebx, memd_a32[ds, 0x133c]);         /* cmp ebx, [0x133c] */
            ii(0x1028_b894, 2); if(jaed(0x1028_b8bc, 0x26)) goto l_0x1028_b8bc; /* jae 0x1028b8bc */
        l_0x1028_b896:
            ii(0x1028_b896, 6); cmp(ebx, memd_a32[ds, 0x1340]);         /* cmp ebx, [0x1340] */
            ii(0x1028_b89c, 2); if(jad(0x1028_b8b0, 0x12)) goto l_0x1028_b8b0; /* ja 0x1028b8b0 */
            ii(0x1028_b89e, 10); mov(memd_a32[ds, 0x1348], 0);          /* mov dword [0x1348], 0x0 */
            ii(0x1028_b8a8, 6); mov(memd_a32[ds, 0x1340], ebx);         /* mov [0x1340], ebx */
            ii(0x1028_b8ae, 2); jmpd(0x1028_b8bc, 0xc); goto l_0x1028_b8bc; /* jmp 0x1028b8bc */
        l_0x1028_b8b0:
            ii(0x1028_b8b0, 6); sub(ebx, memd_a32[ds, 0x1340]);         /* sub ebx, [0x1340] */
            ii(0x1028_b8b6, 6); mov(memd_a32[ds, 0x1348], ebx);         /* mov [0x1348], ebx */
        l_0x1028_b8bc:
            ii(0x1028_b8bc, 6); mov(ebx, memd_a32[ds, 0x1354]);         /* mov ebx, [0x1354] */
            ii(0x1028_b8c2, 2); sub(ebx, edi);                          /* sub ebx, edi */
            ii(0x1028_b8c4, 2); if(jaed(0x1028_b8d4, 0xe)) goto l_0x1028_b8d4; /* jae 0x1028b8d4 */
            ii(0x1028_b8c6, 6); mov(ebx, memd_a32[ds, 0x1366]);         /* mov ebx, [0x1366] */
            ii(0x1028_b8cc, 2); sub(ebx, edi);                          /* sub ebx, edi */
            ii(0x1028_b8ce, 6); add(ebx, memd_a32[ds, 0x1354]);         /* add ebx, [0x1354] */
        l_0x1028_b8d4:
            ii(0x1028_b8d4, 5); mov(eax, memd_a32[ds, 0x1340]);         /* mov eax, [0x1340] */
            ii(0x1028_b8d9, 6); add(eax, memd_a32[ds, 0x1348]);         /* add eax, [0x1348] */
            ii(0x1028_b8df, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1028_b8e1, 2); if(jbd(0x1028_b896, -0x4d)) goto l_0x1028_b896; /* jb 0x1028b896 */
            ii(0x1028_b8e3, 6); mov(edx, memd_a32[ds, 0x1374]);         /* mov edx, [0x1374] */
            ii(0x1028_b8e9, 2); calld_abs(edx);                         /* call edx */
            ii(0x1028_b8eb, 4); mov(memw_a32[ds, esi + 0x3a], di);      /* mov [esi+0x3a], di */
            ii(0x1028_b8ef, 4); movzx(eax, memw_a32[ds, esi + 0x1c]);   /* movzx eax, word [esi+0x1c] */
            ii(0x1028_b8f3, 4); movzx(edx, memw_a32[ds, esi + 0x1e]);   /* movzx edx, word [esi+0x1e] */
            ii(0x1028_b8f7, 6); mov(ecx, memd_a32[ds, 0x1340]);         /* mov ecx, [0x1340] */
            ii(0x1028_b8fd, 6); add(ecx, memd_a32[ds, 0x1348]);         /* add ecx, [0x1348] */
            ii(0x1028_b903, 6); test(memw_a32[ds, esi + 0x30], 0x20);   /* test word [esi+0x30], 0x20 */
            ii(0x1028_b909, 2); if(jzd(0x1028_b90d, 0x2)) goto l_0x1028_b90d; /* jz 0x1028b90d */
            ii(0x1028_b90b, 2); shr(ecx, 0x1);                          /* shr ecx, 1 */
        l_0x1028_b90d:
            ii(0x1028_b90d, 5); cmp(memw_a32[ds, esi + 0x36], 0x3);     /* cmp word [esi+0x36], 0x3 */
            ii(0x1028_b912, 2); if(jzd(0x1028_b916, 0x2)) goto l_0x1028_b916; /* jz 0x1028b916 */
            ii(0x1028_b914, 2); shr(ecx, 0x1);                          /* shr ecx, 1 */
        l_0x1028_b916:
            ii(0x1028_b916, 6); test(memw_a32[ds, esi + 0x30], 0x400);  /* test word [esi+0x30], 0x400 */
            ii(0x1028_b91c, 2); if(jzd(0x1028_b93a, 0x1c)) goto l_0x1028_b93a; /* jz 0x1028b93a */
            ii(0x1028_b91e, 1); pushd(edx);                             /* push edx */
            ii(0x1028_b91f, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b920, 3); mov(ebx, memd_a32[ds, esi + 0x44]);     /* mov ebx, [esi+0x44] */
            ii(0x1028_b923, 3); movzx(eax, cx);                         /* movzx eax, cx */
            ii(0x1028_b926, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1028_b929, 2); mul(ebx);                               /* mul ebx */
            ii(0x1028_b92b, 3); mov(cx, dx);                            /* mov cx, dx */
            ii(0x1028_b92e, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1028_b931, 4); add(memw_a32[ds, esi + 0x6a], ax);      /* add [esi+0x6a], ax */
            ii(0x1028_b935, 3); adc(ecx, 0);                            /* adc ecx, 0x0 */
            ii(0x1028_b938, 1); popd(eax);                              /* pop eax */
            ii(0x1028_b939, 1); popd(edx);                              /* pop edx */
        l_0x1028_b93a:
            ii(0x1028_b93a, 3); add(memd_a32[ds, esi + 0x4c], ecx);     /* add [esi+0x4c], ecx */
            ii(0x1028_b93d, 3); sub(ax, cx);                            /* sub ax, cx */
            ii(0x1028_b940, 4); sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x1028_b944, 4); mov(memw_a32[ds, esi + 0x1c], ax);      /* mov [esi+0x1c], ax */
            ii(0x1028_b948, 4); mov(memw_a32[ds, esi + 0x1e], dx);      /* mov [esi+0x1e], dx */
            ii(0x1028_b94c, 4); sub(ax, 0x4);                           /* sub ax, 0x4 */
            ii(0x1028_b950, 4); sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x1028_b954, 6); test(memw_a32[ds, esi + 0x30], 0x400);  /* test word [esi+0x30], 0x400 */
            ii(0x1028_b95a, 2); if(jzd(0x1028_b95e, 0x2)) goto l_0x1028_b95e; /* jz 0x1028b95e */
            ii(0x1028_b95c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
        l_0x1028_b95e:
            ii(0x1028_b95e, 3); add(memd_a32[ds, esi + 0x8], ecx);      /* add [esi+0x8], ecx */
            ii(0x1028_b961, 3); or(dx, dx);                             /* or dx, dx */
            ii(0x1028_b964, 6); if(jnsd(0x1028_babf, 0x155)) goto l_0x1028_babf; /* jns 0x1028babf */
            ii(0x1028_b96a, 6); test(memw_a32[ds, esi + 0x30], 0x4000); /* test word [esi+0x30], 0x4000 */
            ii(0x1028_b970, 6); if(jzd(0x1028_ba19, 0xa3)) goto l_0x1028_ba19; /* jz 0x1028ba19 */
            ii(0x1028_b976, 5); cmp(memw_a32[ds, esi + 0x38], 0);       /* cmp word [esi+0x38], 0x0 */
            ii(0x1028_b97b, 6); if(jzd(0x1028_ba19, 0x98)) goto l_0x1028_ba19; /* jz 0x1028ba19 */
            ii(0x1028_b981, 5); cmp(memw_a32[ds, esi + 0x38], -0x1 /* 0xff */); /* cmp word [esi+0x38], 0xffff */
            ii(0x1028_b986, 2); if(jzd(0x1028_b98d, 0x5)) goto l_0x1028_b98d; /* jz 0x1028b98d */
            ii(0x1028_b988, 5); sub(memw_a32[ds, esi + 0x38], 0x1);     /* sub word [esi+0x38], 0x1 */
        l_0x1028_b98d:
            ii(0x1028_b98d, 6); test(memw_a32[ds, esi + 0x30], 0x40);   /* test word [esi+0x30], 0x40 */
            ii(0x1028_b993, 2); if(jzd(0x1028_b9b2, 0x1d)) goto l_0x1028_b9b2; /* jz 0x1028b9b2 */
            ii(0x1028_b995, 5); cmp(memw_a32[ds, esi + 0x38], 0);       /* cmp word [esi+0x38], 0x0 */
            ii(0x1028_b99a, 2); if(jzd(0x1028_b9aa, 0xe)) goto l_0x1028_b9aa; /* jz 0x1028b9aa */
            ii(0x1028_b99c, 3); mov(eax, memd_a32[ds, esi + 0x10]);     /* mov eax, [esi+0x10] */
            ii(0x1028_b99f, 3); mov(memd_a32[ds, esi + 0x8], eax);      /* mov [esi+0x8], eax */
            ii(0x1028_b9a2, 3); mov(eax, memd_a32[ds, esi + 0x20]);     /* mov eax, [esi+0x20] */
            ii(0x1028_b9a5, 3); mov(memd_a32[ds, esi + 0x1c], eax);     /* mov [esi+0x1c], eax */
            ii(0x1028_b9a8, 2); jmpd(0x1028_b9bd, 0x13); goto l_0x1028_b9bd; /* jmp 0x1028b9bd */
        l_0x1028_b9aa:
            ii(0x1028_b9aa, 3); mov(eax, memd_a32[ds, esi + 0x2c]);     /* mov eax, [esi+0x2c] */
            ii(0x1028_b9ad, 3); mov(memd_a32[ds, esi + 0x1c], eax);     /* mov [esi+0x1c], eax */
            ii(0x1028_b9b0, 2); jmpd(0x1028_b9bd, 0xb); goto l_0x1028_b9bd; /* jmp 0x1028b9bd */
        l_0x1028_b9b2:
            ii(0x1028_b9b2, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1028_b9b4, 3); mov(memd_a32[ds, esi + 0x8], eax);      /* mov [esi+0x8], eax */
            ii(0x1028_b9b7, 3); mov(eax, memd_a32[ds, esi + 0x18]);     /* mov eax, [esi+0x18] */
            ii(0x1028_b9ba, 3); mov(memd_a32[ds, esi + 0x1c], eax);     /* mov [esi+0x1c], eax */
        l_0x1028_b9bd:
            ii(0x1028_b9bd, 4); cmp(memd_a32[ds, esi + 0x3c], 0);       /* cmp dword [esi+0x3c], 0x0 */
            ii(0x1028_b9c1, 2); if(jzd(0x1028_ba0e, 0x4b)) goto l_0x1028_ba0e; /* jz 0x1028ba0e */
            ii(0x1028_b9c3, 6); test(memw_a32[ds, esi + 0x30], 0x4);    /* test word [esi+0x30], 0x4 */
            ii(0x1028_b9c9, 2); if(jnzd(0x1028_ba0e, 0x43)) goto l_0x1028_ba0e; /* jnz 0x1028ba0e */
            ii(0x1028_b9cb, 1); pushad();                               /* pushad */
            ii(0x1028_b9cc, 2); pushd(gs);                              /* push gs */
            ii(0x1028_b9ce, 1); pushd(es);                              /* push es */
            ii(0x1028_b9cf, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b9d0, 7); mov(es, memw_a32[ds, 0x139e]);          /* mov es, [0x139e] */
            ii(0x1028_b9d7, 1); pushd(ds);                              /* push ds */
            ii(0x1028_b9d8, 2); popd(gs);                               /* pop gs */
            ii(0x1028_b9da, 8); mov(ds, memw_a32[gs, 0x136e]);          /* mov ds, [gs:0x136e] */
            ii(0x1028_b9e2, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1028_b9e4, 5); sub(eax, 0x3d0);                        /* sub eax, 0x3d0 */
            ii(0x1028_b9e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1028_b9eb, 4); mov(bx, 0x6c);                          /* mov bx, 0x6c */
            ii(0x1028_b9ef, 3); div(bx);                                /* div bx */
            ii(0x1028_b9f2, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b9f3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1028_b9f8, 1); pushd(eax);                             /* push eax */
            ii(0x1028_b9f9, 8); movzx(eax, memw_a32[gs, 0x1388]);       /* movzx eax, word [gs:0x1388] */
            ii(0x1028_ba01, 1); pushd(eax);                             /* push eax */
            ii(0x1028_ba02, 4); calld_a32_far_ind(gs, esi + 0x3c);      /* call far dword [gs:esi+0x3c] */
            ii(0x1028_ba06, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1028_ba09, 1); popd(ds);                               /* pop ds */
            ii(0x1028_ba0a, 1); popd(es);                               /* pop es */
            ii(0x1028_ba0b, 2); popd(gs);                               /* pop gs */
            ii(0x1028_ba0d, 1); popad();                                /* popad */
        l_0x1028_ba0e:
            ii(0x1028_ba0e, 6); mov(ebx, memd_a32[ds, 0x1362]);         /* mov ebx, [0x1362] */
            ii(0x1028_ba14, 5); jmpd(0x1028_b776, -0x2a3); goto l_0x1028_b776; /* jmp 0x1028b776 */
        l_0x1028_ba19:
            ii(0x1028_ba19, 4); cmp(memd_a32[ds, esi + 0x3c], 0);       /* cmp dword [esi+0x3c], 0x0 */
            ii(0x1028_ba1d, 2); if(jzd(0x1028_ba6a, 0x4b)) goto l_0x1028_ba6a; /* jz 0x1028ba6a */
            ii(0x1028_ba1f, 6); test(memw_a32[ds, esi + 0x30], 0x8);    /* test word [esi+0x30], 0x8 */
            ii(0x1028_ba25, 2); if(jnzd(0x1028_ba6a, 0x43)) goto l_0x1028_ba6a; /* jnz 0x1028ba6a */
            ii(0x1028_ba27, 1); pushad();                               /* pushad */
            ii(0x1028_ba28, 2); pushd(gs);                              /* push gs */
            ii(0x1028_ba2a, 1); pushd(es);                              /* push es */
            ii(0x1028_ba2b, 1); pushd(ds);                              /* push ds */
            ii(0x1028_ba2c, 7); mov(es, memw_a32[ds, 0x139e]);          /* mov es, [0x139e] */
            ii(0x1028_ba33, 1); pushd(ds);                              /* push ds */
            ii(0x1028_ba34, 2); popd(gs);                               /* pop gs */
            ii(0x1028_ba36, 8); mov(ds, memw_a32[gs, 0x136e]);          /* mov ds, [gs:0x136e] */
            ii(0x1028_ba3e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1028_ba40, 5); sub(eax, 0x3d0);                        /* sub eax, 0x3d0 */
            ii(0x1028_ba45, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1028_ba47, 4); mov(bx, 0x6c);                          /* mov bx, 0x6c */
            ii(0x1028_ba4b, 3); div(bx);                                /* div bx */
            ii(0x1028_ba4e, 1); pushd(eax);                             /* push eax */
            ii(0x1028_ba4f, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1028_ba54, 1); pushd(eax);                             /* push eax */
            ii(0x1028_ba55, 8); movzx(eax, memw_a32[gs, 0x1388]);       /* movzx eax, word [gs:0x1388] */
            ii(0x1028_ba5d, 1); pushd(eax);                             /* push eax */
            ii(0x1028_ba5e, 4); calld_a32_far_ind(gs, esi + 0x3c);      /* call far dword [gs:esi+0x3c] */
            ii(0x1028_ba62, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1028_ba65, 1); popd(ds);                               /* pop ds */
            ii(0x1028_ba66, 1); popd(es);                               /* pop es */
            ii(0x1028_ba67, 2); popd(gs);                               /* pop gs */
            ii(0x1028_ba69, 1); popad();                                /* popad */
        l_0x1028_ba6a:
            ii(0x1028_ba6a, 6); test(memw_a32[ds, esi + 0x30], 0x800);  /* test word [esi+0x30], 0x800 */
            ii(0x1028_ba70, 2); if(jzd(0x1028_ba83, 0x11)) goto l_0x1028_ba83; /* jz 0x1028ba83 */
            ii(0x1028_ba72, 6); and(memw_a32[ds, esi + 0x30], 0xf7ff);  /* and word [esi+0x30], 0xf7ff */
            ii(0x1028_ba78, 6); mov(ebx, memd_a32[ds, 0x1362]);         /* mov ebx, [0x1362] */
            ii(0x1028_ba7e, 5); jmpd(0x1028_b776, -0x30d); goto l_0x1028_b776; /* jmp 0x1028b776 */
        l_0x1028_ba83:
            ii(0x1028_ba83, 6); or(memw_a32[ds, esi + 0x30], 0x1000);   /* or word [esi+0x30], 0x1000 */
            ii(0x1028_ba89, 6); mov(ebx, memd_a32[ds, 0x132c]);         /* mov ebx, [0x132c] */
            ii(0x1028_ba8f, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1028_ba92, 6); add(ebx, 0x12ac);                       /* add ebx, 0x12ac */
            ii(0x1028_ba98, 2); mov(memd_a32[ds, ebx], esi);            /* mov [ebx], esi */
            ii(0x1028_ba9a, 6); inc(memd_a32[ds, 0x132c]);              /* inc dword [0x132c] */
            ii(0x1028_baa0, 4); movzx(eax, memw_a32[ds, esi + 0x3a]);   /* movzx eax, word [esi+0x3a] */
            ii(0x1028_baa4, 6); sub(eax, memd_a32[ds, 0x1330]);         /* sub eax, [0x1330] */
            ii(0x1028_baaa, 2); if(jaed(0x1028_babb, 0xf)) goto l_0x1028_babb; /* jae 0x1028babb */
            ii(0x1028_baac, 5); mov(eax, memd_a32[ds, 0x1366]);         /* mov eax, [0x1366] */
            ii(0x1028_bab1, 6); sub(eax, memd_a32[ds, 0x1330]);         /* sub eax, [0x1330] */
            ii(0x1028_bab7, 4); add(ax, memw_a32[ds, esi + 0x3a]);      /* add ax, [esi+0x3a] */
        l_0x1028_babb:
            ii(0x1028_babb, 4); mov(memw_a32[ds, esi + 0x24], ax);      /* mov [esi+0x24], ax */
        l_0x1028_babf:
            ii(0x1028_babf, 6); mov(ebx, memd_a32[ds, 0x1362]);         /* mov ebx, [0x1362] */
            ii(0x1028_bac5, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1028_bac8, 6); dec(memd_a32[ds, 0x12a8]);              /* dec dword [0x12a8] */
            ii(0x1028_bace, 7); cmp(memd_a32[ds, 0x12a8], 0);           /* cmp dword [0x12a8], 0x0 */
            ii(0x1028_bad5, 2); if(jzd(0x1028_badc, 0x5)) goto l_0x1028_badc; /* jz 0x1028badc */
            ii(0x1028_bad7, 5); jmpd(0x1028_b776, -0x366); goto l_0x1028_b776; /* jmp 0x1028b776 */
        l_0x1028_badc:
            ii(0x1028_badc, 5); mov(eax, memd_a32[ds, 0x1330]);         /* mov eax, [0x1330] */
            ii(0x1028_bae1, 5); mov(memd_a32[ds, 0x1354], eax);         /* mov [0x1354], eax */
            ii(0x1028_bae6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1028_bae7, 1); popd(edi);                              /* pop edi */
            ii(0x1028_bae8, 1); popd(esi);                              /* pop esi */
            ii(0x1028_bae9, 1); popd(es);                               /* pop es */
            ii(0x1028_baea, 1); popd(ds);                               /* pop ds */
            ii(0x1028_baeb, 6); dec(memd_a32[ds, 0x136a]);              /* dec dword [0x136a] */
        l_0x1028_baf1:
            ii(0x1028_baf1, 1); popad();                                /* popad */
            ii(0x1028_baf2, 2); popd(gs);                               /* pop gs */
            ii(0x1028_baf4, 2); popd(fs);                               /* pop fs */
            ii(0x1028_baf6, 1); popd(es);                               /* pop es */
            ii(0x1028_baf7, 1); popd(ds);                               /* pop ds */
            ii(0x1028_baf8, 1); retfd(); return;                        /* retf */
        }
    }
}
