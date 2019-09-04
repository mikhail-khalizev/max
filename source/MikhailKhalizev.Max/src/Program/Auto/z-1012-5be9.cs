using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5be9-106137b4")]
        public void Method_1012_5be9()
        {
            ii(0x1012_5be9, 5); push(0x38);                             /* push 0x38 */
            ii(0x1012_5bee, 5); call(Definitions.sys_check_available_stack_size, 0x4_015f); /* call 0x10165d52 */
            ii(0x1012_5bf3, 1); push(ebx);                              /* push ebx */
            ii(0x1012_5bf4, 1); push(ecx);                              /* push ecx */
            ii(0x1012_5bf5, 1); push(edx);                              /* push edx */
            ii(0x1012_5bf6, 1); push(esi);                              /* push esi */
            ii(0x1012_5bf7, 1); push(edi);                              /* push edi */
            ii(0x1012_5bf8, 1); push(ebp);                              /* push ebp */
            ii(0x1012_5bf9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5bfb, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_5c01, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_5c04, 5); mov(eax, memd[ds, 0x101c_5c1d]);        /* mov eax, [0x101c5c1d] */
            ii(0x1012_5c09, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_5c0c, 3); add(eax, 5);                            /* add eax, 0x5 */
            ii(0x1012_5c0f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_5c12, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_5c17, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1012_5c1a, 5); jmp(0x1012_5cf2, 0xd3); goto l_0x1012_5cf2; /* jmp 0x10125cf2 */
        l_0x1012_5c1f:
            ii(0x1012_5c1f, 7); cmp(memb[ds, 0x101c_59c9], 0);          /* cmp byte [0x101c59c9], 0x0 */
            ii(0x1012_5c26, 2); if(jz(0x1012_5c3a, 0x12)) goto l_0x1012_5c3a; /* jz 0x10125c3a */
            ii(0x1012_5c28, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1012_5c2d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1012_5c30, 5); mov(eax, 0x101c_5c1c);                  /* mov eax, 0x101c5c1c */
            ii(0x1012_5c35, 5); call(0x1012_4890, -0x13aa);             /* call 0x10124890 */
        l_0x1012_5c3a:
            ii(0x1012_5c3a, 5); jmp(0x1012_5d16, 0xd7); goto l_0x1012_5d16; /* jmp 0x10125d16 */
        l_0x1012_5c3f:
            ii(0x1012_5c3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_5c42, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_5c45, 5); jmp(0x1012_5ccb, 0x81); goto l_0x1012_5ccb; /* jmp 0x10125ccb */
        l_0x1012_5c4a:
            ii(0x1012_5c4a, 7); mov(memd[ss, ebp - 20], 4);             /* mov dword [ebp-0x14], 0x4 */
        l_0x1012_5c51:
            ii(0x1012_5c51, 3); dec(memd[ss, ebp - 20]);                /* dec dword [ebp-0x14] */
            ii(0x1012_5c54, 5); cmp(memw[ss, ebp - 20], -1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x1012_5c59, 2); if(jz(0x1012_5c94, 0x39)) goto l_0x1012_5c94; /* jz 0x10125c94 */
            ii(0x1012_5c5b, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1012_5c5f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_5c65, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_5c6b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_5c70, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1012_5c73, 2); if(jnz(0x1012_5c92, 0x1d)) goto l_0x1012_5c92; /* jnz 0x10125c92 */
            ii(0x1012_5c75, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_5c77, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1012_5c7b, 3); imul(eax, eax, 6);                      /* imul eax, eax, 0x6 */
            ii(0x1012_5c7e, 5); mov(ebx, 0x101c_4090);                  /* mov ebx, 0x101c4090 */
            ii(0x1012_5c83, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1012_5c85, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1012_5c88, 5); mov(eax, 0x101c_5c1c);                  /* mov eax, 0x101c5c1c */
            ii(0x1012_5c8d, 5); call(0x1010_7e6a, -0x1_de28);           /* call 0x10107e6a */
        l_0x1012_5c92:
            ii(0x1012_5c92, 2); jmp(0x1012_5c51, -0x43); goto l_0x1012_5c51; /* jmp 0x10125c51 */
        l_0x1012_5c94:
            ii(0x1012_5c94, 2); jmp(0x1012_5cee, 0x58); goto l_0x1012_5cee; /* jmp 0x10125cee */
        l_0x1012_5c96:
            ii(0x1012_5c96, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_5c98, 5); mov(ebx, 0x101b_9000);                  /* mov ebx, 0x101b9000 */
            ii(0x1012_5c9d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1012_5ca0, 5); mov(eax, 0x101c_5c1c);                  /* mov eax, 0x101c5c1c */
            ii(0x1012_5ca5, 5); call(0x1010_7e6a, -0x1_de40);           /* call 0x10107e6a */
            ii(0x1012_5caa, 2); jmp(0x1012_5cee, 0x42); goto l_0x1012_5cee; /* jmp 0x10125cee */
        l_0x1012_5cac:
            ii(0x1012_5cac, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_5cae, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_5cb2, 3); imul(eax, eax, 6);                      /* imul eax, eax, 0x6 */
            ii(0x1012_5cb5, 5); mov(ebx, 0x101c_4090);                  /* mov ebx, 0x101c4090 */
            ii(0x1012_5cba, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1012_5cbc, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1012_5cbf, 5); mov(eax, 0x101c_5c1c);                  /* mov eax, 0x101c5c1c */
            ii(0x1012_5cc4, 5); call(0x1010_7e6a, -0x1_de5f);           /* call 0x10107e6a */
            ii(0x1012_5cc9, 2); jmp(0x1012_5cee, 0x23); goto l_0x1012_5cee; /* jmp 0x10125cee */
        l_0x1012_5ccb:
            ii(0x1012_5ccb, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_5cce, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1012_5cd1, 5); cmp(memw[ss, ebp - 24], 4);             /* cmp word [ebp-0x18], 0x4 */
            ii(0x1012_5cd6, 2); if(jb(0x1012_5cec, 0x14)) goto l_0x1012_5cec; /* jb 0x10125cec */
            ii(0x1012_5cd8, 5); cmp(memw[ss, ebp - 24], 4);             /* cmp word [ebp-0x18], 0x4 */
            ii(0x1012_5cdd, 6); if(jbe(0x1012_5c4a, -0x99)) goto l_0x1012_5c4a; /* jbe 0x10125c4a */
            ii(0x1012_5ce3, 5); cmp(memw[ss, ebp - 24], 5);             /* cmp word [ebp-0x18], 0x5 */
            ii(0x1012_5ce8, 2); if(jz(0x1012_5c96, -0x54)) goto l_0x1012_5c96; /* jz 0x10125c96 */
            ii(0x1012_5cea, 2); jmp(0x1012_5cac, -0x40); goto l_0x1012_5cac; /* jmp 0x10125cac */
        l_0x1012_5cec:
            ii(0x1012_5cec, 2); jmp(0x1012_5cac, -0x42); goto l_0x1012_5cac; /* jmp 0x10125cac */
        l_0x1012_5cee:
            ii(0x1012_5cee, 2); jmp(0x1012_5d16, 0x26); goto l_0x1012_5d16; /* jmp 0x10125d16 */
        l_0x1012_5cf0:
            ii(0x1012_5cf0, 2); jmp(0x1012_5d16, 0x24); goto l_0x1012_5d16; /* jmp 0x10125d16 */
        l_0x1012_5cf2:
            ii(0x1012_5cf2, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1012_5cf5, 3); mov(memb[ss, ebp - 28], al);            /* mov [ebp-0x1c], al */
            ii(0x1012_5cf8, 4); cmp(memb[ss, ebp - 28], 1);             /* cmp byte [ebp-0x1c], 0x1 */
            ii(0x1012_5cfc, 2); if(jb(0x1012_5d14, 0x16)) goto l_0x1012_5d14; /* jb 0x10125d14 */
            ii(0x1012_5cfe, 4); cmp(memb[ss, ebp - 28], 2);             /* cmp byte [ebp-0x1c], 0x2 */
            ii(0x1012_5d02, 6); if(jbe(0x1012_5c1f, -0xe9)) goto l_0x1012_5c1f; /* jbe 0x10125c1f */
            ii(0x1012_5d08, 4); cmp(memb[ss, ebp - 28], 3);             /* cmp byte [ebp-0x1c], 0x3 */
            ii(0x1012_5d0c, 6); if(jz(0x1012_5c3f, -0xd3)) goto l_0x1012_5c3f; /* jz 0x10125c3f */
            ii(0x1012_5d12, 2); jmp(0x1012_5cf0, -0x24); goto l_0x1012_5cf0; /* jmp 0x10125cf0 */
        l_0x1012_5d14:
            ii(0x1012_5d14, 2); jmp(0x1012_5cf0, -0x26); goto l_0x1012_5cf0; /* jmp 0x10125cf0 */
        l_0x1012_5d16:
            ii(0x1012_5d16, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5d18, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_5d19, 1); pop(edi);                               /* pop edi */
            ii(0x1012_5d1a, 1); pop(esi);                               /* pop esi */
            ii(0x1012_5d1b, 1); pop(edx);                               /* pop edx */
            ii(0x1012_5d1c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_5d1d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_5d1e, 1); ret();                                  /* ret */
        }
    }
}
