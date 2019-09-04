using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_9e2e-3306edfb")]
        public void Method_100c_9e2e()
        {
            ii(0x100c_9e2e, 5); push(0x38);                             /* push 0x38 */
            ii(0x100c_9e33, 5); call(Definitions.sys_check_available_stack_size, 0x9_bf1a); /* call 0x10165d52 */
            ii(0x100c_9e38, 1); push(ecx);                              /* push ecx */
            ii(0x100c_9e39, 1); push(esi);                              /* push esi */
            ii(0x100c_9e3a, 1); push(edi);                              /* push edi */
            ii(0x100c_9e3b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_9e3c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_9e3e, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100c_9e44, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_9e47, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100c_9e4a, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100c_9e4d, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_9e51, 6); if(jz(0x100c_9faa, 0x153)) goto l_0x100c_9faa; /* jz 0x100c9faa */
            ii(0x100c_9e57, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9e5a, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100c_9e5d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9e62, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_9e68, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_9e6e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9e73, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x100c_9e76, 2); if(jnz(0x100c_9e83, 0xb)) goto l_0x100c_9e83; /* jnz 0x100c9e83 */
            ii(0x100c_9e78, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_9e7b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_9e7e, 5); call(0x100c_9b42, -0x341);              /* call 0x100c9b42 */
        l_0x100c_9e83:
            ii(0x100c_9e83, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9e86, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100c_9e89, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9e8e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_9e94, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_9e9a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9e9f, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100c_9ea2, 6); if(jnz(0x100c_9faa, 0x102)) goto l_0x100c_9faa; /* jnz 0x100c9faa */
            ii(0x100c_9ea8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_9eaa, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_9ead, 3); mov(al, memb[ds, edx + 77]);            /* mov al, [edx+0x4d] */
            ii(0x100c_9eb0, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_9eb3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9eb6, 5); call(0x1007_6154, -0x5_3d67);           /* call 0x10076154 */
            ii(0x100c_9ebb, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100c_9ec0, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x100c_9ec5, 2); if(jnz(0x100c_9efb, 0x34)) goto l_0x100c_9efb; /* jnz 0x100c9efb */
            ii(0x100c_9ec7, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100c_9ecc, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x100c_9ed0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9ed3, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x100c_9ed6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_9ed9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9edc, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100c_9edf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9ee4, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100c_9eea, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x100c_9eef, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100c_9ef1, 5); call(0x100c_204f, -0x7ea7);             /* call 0x100c204f */
            ii(0x100c_9ef6, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_9ef9, 2); jmp(0x100c_9f27, 0x2c); goto l_0x100c_9f27; /* jmp 0x100c9f27 */
        l_0x100c_9efb:
            ii(0x100c_9efb, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100c_9f00, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x100c_9f04, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_9f07, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_9f0a, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100c_9f0d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9f12, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100c_9f18, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x100c_9f1d, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100c_9f1f, 5); call(0x100c_1fd4, -0x7f50);             /* call 0x100c1fd4 */
            ii(0x100c_9f24, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
        l_0x100c_9f27:
            ii(0x100c_9f27, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100c_9f2b, 6); if(jz(0x100c_9faa, 0x79)) goto l_0x100c_9faa; /* jz 0x100c9faa */
            ii(0x100c_9f31, 4); cmp(memb[ss, ebp - 4], 3);              /* cmp byte [ebp-0x4], 0x3 */
            ii(0x100c_9f35, 2); if(jnz(0x100c_9f3e, 7)) goto l_0x100c_9f3e; /* jnz 0x100c9f3e */
            ii(0x100c_9f37, 7); mov(memd[ss, ebp - 16], 1);             /* mov dword [ebp-0x10], 0x1 */
        l_0x100c_9f3e:
            ii(0x100c_9f3e, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_9f45, 2); jmp(0x100c_9f4d, 6); goto l_0x100c_9f4d; /* jmp 0x100c9f4d */
        l_0x100c_9f47:
            ii(0x100c_9f47, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_9f4a, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x100c_9f4d:
            ii(0x100c_9f4d, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_9f50, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_9f57, 2); if(jge(0x100c_9faa, 0x51)) goto l_0x100c_9faa; /* jge 0x100c9faa */
            ii(0x100c_9f59, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_9f5d, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_9f60, 3); add(eax, memd[ss, ebp - 20]);           /* add eax, [ebp-0x14] */
            ii(0x100c_9f63, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9f65, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_9f68, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_9f6c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_9f6f, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x100c_9f72, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9f74, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_9f77, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x100c_9f7d, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
        l_0x100c_9f80:
            ii(0x100c_9f80, 3); dec(memd[ss, ebp - 36]);                /* dec dword [ebp-0x24] */
            ii(0x100c_9f83, 5); cmp(memw[ss, ebp - 36], -1 /* 0xff */); /* cmp word [ebp-0x24], 0xffff */
            ii(0x100c_9f88, 2); if(jz(0x100c_9fa8, 0x1e)) goto l_0x100c_9fa8; /* jz 0x100c9fa8 */
            ii(0x100c_9f8a, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_9f8d, 4); add(memd[ss, ebp - 28], 2);             /* add dword [ebp-0x1c], 0x2 */
            ii(0x100c_9f91, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100c_9f94, 4); cmp(ax, memw[ss, ebp - 16]);            /* cmp ax, [ebp-0x10] */
            ii(0x100c_9f98, 2); if(jl(0x100c_9fa0, 6)) goto l_0x100c_9fa0; /* jl 0x100c9fa0 */
            ii(0x100c_9f9a, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_9f9d, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
        l_0x100c_9fa0:
            ii(0x100c_9fa0, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_9fa3, 3); inc(memd[ss, ebp - 32]);                /* inc dword [ebp-0x20] */
            ii(0x100c_9fa6, 2); jmp(0x100c_9f80, -0x28); goto l_0x100c_9f80; /* jmp 0x100c9f80 */
        l_0x100c_9fa8:
            ii(0x100c_9fa8, 2); jmp(0x100c_9f47, -0x63); goto l_0x100c_9f47; /* jmp 0x100c9f47 */
        l_0x100c_9faa:
            ii(0x100c_9faa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9fac, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_9fad, 1); pop(edi);                               /* pop edi */
            ii(0x100c_9fae, 1); pop(esi);                               /* pop esi */
            ii(0x100c_9faf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_9fb0, 1); ret();                                  /* ret */
        }
    }
}
