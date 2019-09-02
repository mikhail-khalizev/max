using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6bd8-8b2e3ec")]
        public void /* sys */ Method_1018_6bd8()
        {
            ii(0x1018_6bd8, 1); push(ebx);                              /* push ebx */
            ii(0x1018_6bd9, 1); push(ecx);                              /* push ecx */
            ii(0x1018_6bda, 1); push(esi);                              /* push esi */
            ii(0x1018_6bdb, 1); push(edi);                              /* push edi */
            ii(0x1018_6bdc, 1); push(ebp);                              /* push ebp */
            ii(0x1018_6bdd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_6bdf, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_6be1, 5); call(/* sys */ 0x1018_6b7c, -0x6a);     /* call 0x10186b7c */
            ii(0x1018_6be6, 6); mov(edx, memd[ds, 0x101b_de0c]);        /* mov edx, [0x101bde0c] */
            ii(0x1018_6bec, 5); jmp(0x1018_6cc7, 0xd6); goto l_0x1018_6cc7; /* jmp 0x10186cc7 */
        l_0x1018_6bf1:
            ii(0x1018_6bf1, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1018_6bf3, 6); if(ja(0x1018_6ccf, 0xd6)) goto l_0x1018_6ccf; /* ja 0x10186ccf */
            ii(0x1018_6bf9, 3); lea(eax, memd[ds, edx + 0x2c]);         /* lea eax, [edx+0x2c] */
            ii(0x1018_6bfc, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1018_6bfe, 6); if(jnz(0x1018_6cc4, 0xc0)) goto l_0x1018_6cc4; /* jnz 0x10186cc4 */
            ii(0x1018_6c04, 4); cmp(memd[ds, edx + 0x18], 1);           /* cmp dword [edx+0x18], 0x1 */
            ii(0x1018_6c08, 6); if(jnz(0x1018_6cc4, 0xb6)) goto l_0x1018_6cc4; /* jnz 0x10186cc4 */
            ii(0x1018_6c0e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_6c10, 5); call(/* sys */ 0x1018_6b2b, -0xea);     /* call 0x10186b2b */
            ii(0x1018_6c15, 3); lea(eax, memd[ds, edx - 8]);            /* lea eax, [edx-0x8] */
            ii(0x1018_6c18, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x1018_6c1c, 6); if(jnz(0x1018_6ccf, 0xad)) goto l_0x1018_6ccf; /* jnz 0x10186ccf */
            ii(0x1018_6c22, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1018_6c24, 2); mov(ebx, memd[ds, ebx]);                /* mov ebx, [ebx] */
            ii(0x1018_6c26, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1018_6c28, 3); sub(ebx, 4);                            /* sub ebx, 0x4 */
            ii(0x1018_6c2b, 3); add(edx, 0xc);                          /* add edx, 0xc */
            ii(0x1018_6c2e, 2); sub(ecx, ebx);                          /* sub ecx, ebx */
            ii(0x1018_6c30, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1018_6c32, 6); add(edx, 0xfff);                        /* add edx, 0xfff */
            ii(0x1018_6c38, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1018_6c3a, 3); and(dh, 0xf0);                          /* and dh, 0xf0 */
            ii(0x1018_6c3d, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_6c3f, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_6c41, 3); shr(ebx, 0x10);                         /* shr ebx, 0x10 */
            ii(0x1018_6c44, 3); mov(di, memw[ds, eax]);                 /* mov di, [eax] */
            ii(0x1018_6c47, 4); mov(si, memw[ds, eax + 2]);             /* mov si, [eax+0x2] */
            ii(0x1018_6c4b, 2); mov(ah, 5);                             /* mov ah, 0x5 */
            ii(0x1018_6c4d, 2); mov(al, 3);                             /* mov al, 0x3 */
            ii(0x1018_6c4f, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1018_6c51, 2); sbb(eax, eax);                          /* sbb eax, eax */
            ii(0x1018_6c53, 1); inc(eax);                               /* inc eax */
            ii(0x1018_6c54, 2); if(jz(0x1018_6c66, 0x10)) goto l_0x1018_6c66; /* jz 0x10186c66 */
            ii(0x1018_6c56, 3); mov(ax, bx);                            /* mov ax, bx */
            ii(0x1018_6c59, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_6c5c, 3); mov(ax, cx);                            /* mov ax, cx */
            ii(0x1018_6c5f, 3); mov(memw[ds, eax], di);                 /* mov [eax], di */
            ii(0x1018_6c62, 4); mov(memw[ds, eax + 2], si);             /* mov [eax+0x2], si */
        l_0x1018_6c66:
            ii(0x1018_6c66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6c68, 2); if(jz(0x1018_6cd1, 0x67)) goto l_0x1018_6cd1; /* jz 0x10186cd1 */
            ii(0x1018_6c6a, 3); lea(ebx, memd[ds, eax + 8]);            /* lea ebx, [eax+0x8] */
            ii(0x1018_6c6d, 3); sub(edx, 0xc);                          /* sub edx, 0xc */
            ii(0x1018_6c70, 1); inc(ebp);                               /* inc ebp */
            ii(0x1018_6c71, 7); mov(memd[ds, eax + 4], 0);              /* mov dword [eax+0x4], 0x0 */
            ii(0x1018_6c78, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6c7a, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
            ii(0x1018_6c7c, 5); call(/* sys */ 0x1018_6cd7, 0x56);      /* call 0x10186cd7 */
            ii(0x1018_6c81, 7); mov(memd[ds, ebx + 0x18], 1);           /* mov dword [ebx+0x18], 0x1 */
            ii(0x1018_6c88, 3); and(ebp, -2 /* 0xfe */);                /* and ebp, 0xfffffffe */
            ii(0x1018_6c8b, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1018_6c8d, 2); sub(edx, ebp);                          /* sub edx, ebp */
            ii(0x1018_6c8f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_6c91, 3); cmp(edx, 0xc);                          /* cmp edx, 0xc */
            ii(0x1018_6c94, 2); if(jb(0x1018_6cbd, 0x27)) goto l_0x1018_6cbd; /* jb 0x10186cbd */
            ii(0x1018_6c96, 2); mov(esi, ebp);                          /* mov esi, ebp */
            ii(0x1018_6c98, 4); or(si, 1);                              /* or si, 0x1 */
            ii(0x1018_6c9c, 2); mov(memd[ds, eax], esi);                /* mov [eax], esi */
            ii(0x1018_6c9e, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1018_6ca0, 3); or(dl, 1);                              /* or dl, 0x1 */
            ii(0x1018_6ca3, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_6ca5, 3); mov(edi, memd[ds, ebx + 0x18]);         /* mov edi, [ebx+0x18] */
            ii(0x1018_6ca8, 7); mov(memd[ds, ebx + 0x14], 0xffff_ffff); /* mov dword [ebx+0x14], 0xffffffff */
            ii(0x1018_6caf, 1); inc(edi);                               /* inc edi */
            ii(0x1018_6cb0, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1018_6cb3, 3); mov(memd[ds, ebx + 0x18], edi);         /* mov [ebx+0x18], edi */
            ii(0x1018_6cb6, 5); call(Definitions.sys_free, -0x1_bbfa);  /* call 0x1016b0c1 */
            ii(0x1018_6cbb, 2); jmp(0x1018_6cc0, 3); goto l_0x1018_6cc0; /* jmp 0x10186cc0 */
        l_0x1018_6cbd:
            ii(0x1018_6cbd, 3); or(memb[ds, eax], 1);                   /* or byte [eax], 0x1 */
        l_0x1018_6cc0:
            ii(0x1018_6cc0, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_6cc2, 2); jmp(0x1018_6cd1, 0xd); goto l_0x1018_6cd1; /* jmp 0x10186cd1 */
        l_0x1018_6cc4:
            ii(0x1018_6cc4, 3); mov(edx, memd[ds, edx + 8]);            /* mov edx, [edx+0x8] */
        l_0x1018_6cc7:
            ii(0x1018_6cc7, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_6cc9, 6); if(jnz(0x1018_6bf1, -0xde)) goto l_0x1018_6bf1; /* jnz 0x10186bf1 */
        l_0x1018_6ccf:
            ii(0x1018_6ccf, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1018_6cd1:
            ii(0x1018_6cd1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_6cd2, 1); pop(edi);                               /* pop edi */
            ii(0x1018_6cd3, 1); pop(esi);                               /* pop esi */
            ii(0x1018_6cd4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_6cd5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_6cd6, 1); ret();                                  /* ret */
        }
    }
}
