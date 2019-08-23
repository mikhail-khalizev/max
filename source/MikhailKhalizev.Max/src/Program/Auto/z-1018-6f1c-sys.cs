using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6f1c-76c15f60")]
        public void /* sys */ Method_1018_6f1c()
        {
            ii(0x1018_6f1c, 1); push(ebx);                              /* push ebx */
            ii(0x1018_6f1d, 1); push(ecx);                              /* push ecx */
            ii(0x1018_6f1e, 1); push(edx);                              /* push edx */
            ii(0x1018_6f1f, 1); push(esi);                              /* push esi */
            ii(0x1018_6f20, 1); push(ebp);                              /* push ebp */
            ii(0x1018_6f21, 1); push(eax);                              /* push eax */
            ii(0x1018_6f22, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6f24, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1018_6f29, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_6f2c, 2); if(jnz(0x1018_6f37, 0x9)) goto l_0x1018_6f37; /* jnz 0x10186f37 */
            ii(0x1018_6f2e, 7); cmp(memb[ds, 0x101b_e58f], 0);          /* cmp byte [0x101be58f], 0x0 */
            ii(0x1018_6f35, 2); if(jz(0x1018_6f43, 0xc)) goto l_0x1018_6f43; /* jz 0x10186f43 */
        l_0x1018_6f37:
            ii(0x1018_6f37, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6f39, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1018_6f3e, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1018_6f41, 2); if(jnz(0x1018_6f50, 0xd)) goto l_0x1018_6f50; /* jnz 0x10186f50 */
        l_0x1018_6f43:
            ii(0x1018_6f43, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_6f46, 5); call(/* sys */ 0x1018_6e6c, -0xdf);     /* call 0x10186e6c */
            ii(0x1018_6f4b, 5); jmp(0x1018_705f, 0x10f); goto l_0x1018_705f; /* jmp 0x1018705f */
        l_0x1018_6f50:
            ii(0x1018_6f50, 7); cmp(memd[ds, 0x101c_1c50], 0);          /* cmp dword [0x101c1c50], 0x0 */
            ii(0x1018_6f57, 2); if(jnz(0x1018_6f60, 0x7)) goto l_0x1018_6f60; /* jnz 0x10186f60 */
        l_0x1018_6f59:
            ii(0x1018_6f59, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6f5b, 5); jmp(0x1018_705f, 0xff); goto l_0x1018_705f; /* jmp 0x1018705f */
        l_0x1018_6f60:
            ii(0x1018_6f60, 7); cmp(memd[ds, 0x101b_e560], -0x2 /* 0xfe */); /* cmp dword [0x101be560], 0xfffffffe */
            ii(0x1018_6f67, 2); if(jz(0x1018_6f59, -0x10)) goto l_0x1018_6f59; /* jz 0x10186f59 */
            ii(0x1018_6f69, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1018_6f6b, 5); call(/* sys */ 0x1018_7068, 0xf8);      /* call 0x10187068 */
            ii(0x1018_6f70, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6f72, 6); if(jz(0x1018_705f, 0xe7)) goto l_0x1018_705f; /* jz 0x1018705f */
            ii(0x1018_6f78, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6f7a, 5); mov(al, memb[ds, 0x101b_e58e]);         /* mov al, [0x101be58e] */
            ii(0x1018_6f7f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1018_6f82, 2); if(jl(0x1018_6fa0, 0x1c)) goto l_0x1018_6fa0; /* jl 0x10186fa0 */
            ii(0x1018_6f84, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1018_6f87, 2); if(jg(0x1018_6fa0, 0x17)) goto l_0x1018_6fa0; /* jg 0x10186fa0 */
            ii(0x1018_6f89, 7); cmp(memb[ds, 0x101b_e590], 0);          /* cmp byte [0x101be590], 0x0 */
            ii(0x1018_6f90, 2); if(jnz(0x1018_6fa0, 0xe)) goto l_0x1018_6fa0; /* jnz 0x10186fa0 */
            ii(0x1018_6f92, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6f94, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_6f97, 3); lsl(eax, ax);                           /* lsl eax, ax */
            ii(0x1018_6f9a, 1); inc(eax);                               /* inc eax */
            ii(0x1018_6f9b, 5); mov(memd[ds, 0x101b_e560], eax);        /* mov [0x101be560], eax */
        l_0x1018_6fa0:
            ii(0x1018_6fa0, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1018_6fa3, 6); mov(ecx, memd[ds, 0x101b_e560]);        /* mov ecx, [0x101be560] */
            ii(0x1018_6fa9, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1018_6fab, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1018_6fad, 2); if(jae(0x1018_6fb4, 0x5)) goto l_0x1018_6fb4; /* jae 0x10186fb4 */
            ii(0x1018_6faf, 5); mov(edx, 0xffff_fffe);                  /* mov edx, 0xfffffffe */
        l_0x1018_6fb4:
            ii(0x1018_6fb4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_6fb6, 5); call(/* sys */ 0x1019_a8e8, 0x1_392d);  /* call 0x1019a8e8 */
            ii(0x1018_6fbb, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_6fbe, 2); if(jz(0x1018_6f59, -0x67)) goto l_0x1018_6f59; /* jz 0x10186f59 */
            ii(0x1018_6fc0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_6fc2, 3); cmp(eax, -0x8 /* 0xf8 */);              /* cmp eax, 0xfffffff8 */
            ii(0x1018_6fc5, 2); if(ja(0x1018_6f59, -0x6e)) goto l_0x1018_6f59; /* ja 0x10186f59 */
            ii(0x1018_6fc7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1018_6fc9, 2); if(jbe(0x1018_6f59, -0x72)) goto l_0x1018_6f59; /* jbe 0x10186f59 */
            ii(0x1018_6fcb, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1018_6fcd, 3); mov(memd[ss, esp], edx);                /* mov [esp], edx */
            ii(0x1018_6fd0, 3); lea(eax, edx - 0x4);                    /* lea eax, [edx-0x4] */
            ii(0x1018_6fd3, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_6fd5, 2); if(ja(0x1018_6f59, -0x7e)) goto l_0x1018_6f59; /* ja 0x10186f59 */
            ii(0x1018_6fd7, 6); mov(edx, memd[ds, 0x101b_de0c]);        /* mov edx, [0x101bde0c] */
            ii(0x1018_6fdd, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1018_6fe0, 2); jmp(0x1018_6ff4, 0x12); goto l_0x1018_6ff4; /* jmp 0x10186ff4 */
        l_0x1018_6fe2:
            ii(0x1018_6fe2, 3); mov(ebp, memd[ds, edx + 0x8]);          /* mov ebp, [edx+0x8] */
            ii(0x1018_6fe5, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1018_6fe7, 2); if(jz(0x1018_6ff8, 0xf)) goto l_0x1018_6ff8; /* jz 0x10186ff8 */
            ii(0x1018_6fe9, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1018_6feb, 2); if(ja(0x1018_6ff1, 0x4)) goto l_0x1018_6ff1; /* ja 0x10186ff1 */
            ii(0x1018_6fed, 2); cmp(ebx, ebp);                          /* cmp ebx, ebp */
            ii(0x1018_6fef, 2); if(jb(0x1018_6ff8, 0x7)) goto l_0x1018_6ff8; /* jb 0x10186ff8 */
        l_0x1018_6ff1:
            ii(0x1018_6ff1, 3); mov(edx, memd[ds, edx + 0x8]);          /* mov edx, [edx+0x8] */
        l_0x1018_6ff4:
            ii(0x1018_6ff4, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_6ff6, 2); if(jnz(0x1018_6fe2, -0x16)) goto l_0x1018_6fe2; /* jnz 0x10186fe2 */
        l_0x1018_6ff8:
            ii(0x1018_6ff8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_6ffa, 2); if(jz(0x1018_7022, 0x26)) goto l_0x1018_7022; /* jz 0x10187022 */
            ii(0x1018_6ffc, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1018_6ffe, 3); lea(ecx, ebx - 0x4);                    /* lea ecx, [ebx-0x4] */
            ii(0x1018_7001, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_7003, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1018_7005, 2); if(jnz(0x1018_7022, 0x1b)) goto l_0x1018_7022; /* jnz 0x10187022 */
            ii(0x1018_7007, 3); mov(esi, memd[ss, esp]);                /* mov esi, [esp] */
            ii(0x1018_700a, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1018_700d, 3); mov(memd[ss, esp], esi);                /* mov [esp], esi */
            ii(0x1018_7010, 2); add(memd[ds, edx], esi);                /* add [edx], esi */
            ii(0x1018_7012, 3); mov(ebp, memd[ss, esp]);                /* mov ebp, [esp] */
            ii(0x1018_7015, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_7017, 3); lea(ecx, eax + ebp);                    /* lea ecx, [eax+ebp] */
            ii(0x1018_701a, 6); mov(memd[ds, ecx], 0xffff_ffff);        /* mov dword [ecx], 0xffffffff */
            ii(0x1018_7020, 2); jmp(0x1018_7041, 0x1f); goto l_0x1018_7041; /* jmp 0x10187041 */
        l_0x1018_7022:
            ii(0x1018_7022, 4); cmp(memd[ss, esp], 0x38);               /* cmp dword [esp], 0x38 */
            ii(0x1018_7026, 6); if(jb(0x1018_6f59, -0xd3)) goto l_0x1018_6f59; /* jb 0x10186f59 */
            ii(0x1018_702c, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_702f, 2); mov(memd[ds, ebx], eax);                /* mov [ebx], eax */
            ii(0x1018_7031, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_7033, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_7035, 5); call(/* sys */ 0x1018_6cd7, -0x363);    /* call 0x10186cd7 */
            ii(0x1018_703a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_703c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_703e, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
        l_0x1018_7041:
            ii(0x1018_7041, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_7044, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1018_7046, 2); mov(memd[ds, ebx], eax);                /* mov [ebx], eax */
            ii(0x1018_7048, 3); inc(memd[ds, edx + 0x18]);              /* inc dword [edx+0x18] */
            ii(0x1018_704b, 3); lea(eax, ebx + 0x4);                    /* lea eax, [ebx+0x4] */
            ii(0x1018_704e, 7); mov(memd[ds, edx + 0x14], 0xffff_ffff); /* mov dword [edx+0x14], 0xffffffff */
            ii(0x1018_7055, 5); call(Definitions.sys_free, -0x1_bf99);  /* call 0x1016b0c1 */
            ii(0x1018_705a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1018_705f:
            ii(0x1018_705f, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1018_7062, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_7063, 1); pop(esi);                               /* pop esi */
            ii(0x1018_7064, 1); pop(edx);                               /* pop edx */
            ii(0x1018_7065, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_7066, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_7067, 1); ret();                                  /* ret */
        }
    }
}
