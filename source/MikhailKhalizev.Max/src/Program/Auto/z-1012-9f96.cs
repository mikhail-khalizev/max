using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_9f96-457555a6")]
        public void Method_1012_9f96()
        {
            ii(0x1012_9f96, 5); push(0x30);                             /* push 0x30 */
            ii(0x1012_9f9b, 5); call(Definitions.sys_check_available_stack_size, 0x3_bdb2); /* call 0x10165d52 */
            ii(0x1012_9fa0, 1); push(ebx);                              /* push ebx */
            ii(0x1012_9fa1, 1); push(ecx);                              /* push ecx */
            ii(0x1012_9fa2, 1); push(edx);                              /* push edx */
            ii(0x1012_9fa3, 1); push(esi);                              /* push esi */
            ii(0x1012_9fa4, 1); push(edi);                              /* push edi */
            ii(0x1012_9fa5, 1); push(ebp);                              /* push ebp */
            ii(0x1012_9fa6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_9fa8, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1012_9fae, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_9fb1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_9fb4, 5); call(0x1007_6338, -0xb_3c81);           /* call 0x10076338 */
            ii(0x1012_9fb9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_9fbb, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_9fbe, 5); call(0x1007_64b8, -0xb_3b0b);           /* call 0x100764b8 */
            ii(0x1012_9fc3, 2); jmp(0x1012_9fcd, 8); goto l_0x1012_9fcd; /* jmp 0x10129fcd */
        l_0x1012_9fc5:
            ii(0x1012_9fc5, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_9fc8, 5); call(0x1007_6bf8, -0xb_33d5);           /* call 0x10076bf8 */
        l_0x1012_9fcd:
            ii(0x1012_9fcd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9fcf, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_9fd2, 5); call(0x1013_ad71, 0x1_0d9a);            /* call 0x1013ad71 */
            ii(0x1012_9fd7, 2); test(al, al);                           /* test al, al */
            ii(0x1012_9fd9, 6); if(jz(0x1012_a0df, 0x100)) goto l_0x1012_a0df; /* jz 0x1012a0df */
            ii(0x1012_9fdf, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_9fe2, 5); call(0x1007_63a0, -0xb_3c47);           /* call 0x100763a0 */
            ii(0x1012_9fe7, 5); cmp(memw[ds, eax + 8], 0x28);           /* cmp word [eax+0x8], 0x28 */
            ii(0x1012_9fec, 6); if(jz(0x1012_a0da, 0xe8)) goto l_0x1012_a0da; /* jz 0x1012a0da */
            ii(0x1012_9ff2, 7); mov(memd[ss, ebp - 20], 4);             /* mov dword [ebp-0x14], 0x4 */
        l_0x1012_9ff9:
            ii(0x1012_9ff9, 3); dec(memd[ss, ebp - 20]);                /* dec dword [ebp-0x14] */
            ii(0x1012_9ffc, 5); cmp(memw[ss, ebp - 20], -1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x1012_a001, 2); if(jz(0x1012_a010, 0xd)) goto l_0x1012_a010; /* jz 0x1012a010 */
            ii(0x1012_a003, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1012_a007, 7); mov(memb[ds, eax + 0x101c_59e0], 0);    /* mov byte [eax+0x101c59e0], 0x0 */
            ii(0x1012_a00e, 2); jmp(0x1012_9ff9, -0x17); goto l_0x1012_9ff9; /* jmp 0x10129ff9 */
        l_0x1012_a010:
            ii(0x1012_a010, 7); mov(memb[ds, 0x101c_5c1c], 0x17);       /* mov byte [0x101c5c1c], 0x17 */
            ii(0x1012_a017, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_a01a, 5); call(0x1007_63a0, -0xb_3c7f);           /* call 0x100763a0 */
            ii(0x1012_a01f, 5); call(0x1007_6154, -0xb_3ed0);           /* call 0x10076154 */
            ii(0x1012_a024, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_a02a, 5); mov(edx, 0x101c_5c21);                  /* mov edx, 0x101c5c21 */
            ii(0x1012_a02f, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_a032, 5); call(0x1007_6408, -0xb_3c2f);           /* call 0x10076408 */
            ii(0x1012_a037, 5); call(0x1012_62e2, -0x3d5a);             /* call 0x101262e2 */
            ii(0x1012_a03c, 6); mov(memw[ds, 0x101c_5c1f], ax);         /* mov [0x101c5c1f], ax */
            ii(0x1012_a042, 5); mov(eax, 4);                            /* mov eax, 0x4 */
            ii(0x1012_a047, 5); call(0x1012_5be9, -0x4463);             /* call 0x10125be9 */
            ii(0x1012_a04c, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
        l_0x1012_a050:
            ii(0x1012_a050, 4); cmp(memb[ss, ebp - 16], 0);             /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1012_a054, 2); if(jz(0x1012_a05f, 9)) goto l_0x1012_a05f; /* jz 0x1012a05f */
            ii(0x1012_a056, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_a05d, 2); if(jnz(0x1012_a064, 5)) goto l_0x1012_a064; /* jnz 0x1012a064 */
        l_0x1012_a05f:
            ii(0x1012_a05f, 5); jmp(0x1012_a0da, 0x76); goto l_0x1012_a0da; /* jmp 0x1012a0da */
        l_0x1012_a064:
            ii(0x1012_a064, 5); call(0x1012_75ed, -0x2a7c);             /* call 0x101275ed */
            ii(0x1012_a069, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a06b, 5); call(0x1010_0efe, -0x2_9172);           /* call 0x10100efe */
            ii(0x1012_a070, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x1012_a074, 7); mov(memd[ss, ebp - 20], 4);             /* mov dword [ebp-0x14], 0x4 */
        l_0x1012_a07b:
            ii(0x1012_a07b, 3); dec(memd[ss, ebp - 20]);                /* dec dword [ebp-0x14] */
            ii(0x1012_a07e, 5); cmp(memw[ss, ebp - 20], -1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x1012_a083, 2); if(jz(0x1012_a0b8, 0x33)) goto l_0x1012_a0b8; /* jz 0x1012a0b8 */
            ii(0x1012_a085, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1012_a089, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_a08f, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_a095, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_a09a, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1012_a09d, 2); if(jnz(0x1012_a0b6, 0x17)) goto l_0x1012_a0b6; /* jnz 0x1012a0b6 */
            ii(0x1012_a09f, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1012_a0a3, 6); mov(al, memb[ds, eax + 0x101c_59e0]);   /* mov al, [eax+0x101c59e0] */
            ii(0x1012_a0a9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_a0ae, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a0b0, 2); if(jnz(0x1012_a0b6, 4)) goto l_0x1012_a0b6; /* jnz 0x1012a0b6 */
            ii(0x1012_a0b2, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
        l_0x1012_a0b6:
            ii(0x1012_a0b6, 2); jmp(0x1012_a07b, -0x3d); goto l_0x1012_a07b; /* jmp 0x1012a07b */
        l_0x1012_a0b8:
            ii(0x1012_a0b8, 5); call(/* sys */ 0x1016_b208, 0x4_114b);  /* call 0x1016b208 */
            ii(0x1012_a0bd, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_a0c0, 2); if(jnz(0x1012_a0d5, 0x13)) goto l_0x1012_a0d5; /* jnz 0x1012a0d5 */
            ii(0x1012_a0c2, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_a0c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_a0cb, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_a0ce, 5); call(0x1007_5f6c, -0xb_4167);           /* call 0x10075f6c */
            ii(0x1012_a0d3, 2); jmp(0x1012_a0fc, 0x27); goto l_0x1012_a0fc; /* jmp 0x1012a0fc */
        l_0x1012_a0d5:
            ii(0x1012_a0d5, 5); jmp(0x1012_a050, -0x8a); goto l_0x1012_a050; /* jmp 0x1012a050 */
        l_0x1012_a0da:
            ii(0x1012_a0da, 5); jmp(0x1012_9fc5, -0x11a); goto l_0x1012_9fc5; /* jmp 0x10129fc5 */
        l_0x1012_a0df:
            ii(0x1012_a0df, 7); mov(memd[ss, ebp - 12], 1);             /* mov dword [ebp-0xc], 0x1 */
            ii(0x1012_a0e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_a0e8, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_a0eb, 5); call(0x1007_5f6c, -0xb_4184);           /* call 0x10075f6c */
            ii(0x1012_a0f0, 2); jmp(0x1012_a0fc, 0xa); goto l_0x1012_a0fc; /* jmp 0x1012a0fc */
        //  ii(0x1012_a0f2, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1012_a0f4, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
        //  ii(0x1012_a0f7, 5); call(0x1007_5f6c, -0xb_4190);           /* call 0x10075f6c */
        l_0x1012_a0fc:
            ii(0x1012_a0fc, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_a0ff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a101, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_a102, 1); pop(edi);                               /* pop edi */
            ii(0x1012_a103, 1); pop(esi);                               /* pop esi */
            ii(0x1012_a104, 1); pop(edx);                               /* pop edx */
            ii(0x1012_a105, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_a106, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_a107, 1); ret();                                  /* ret */
        }
    }
}
