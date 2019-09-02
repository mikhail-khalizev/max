using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3ef5-174e4f50")]
        public void Method_1015_3ef5()
        {
            ii(0x1015_3ef5, 5); push(0x34);                             /* push 0x34 */
            ii(0x1015_3efa, 5); call(Definitions.sys_check_available_stack_size, 0x1_1e53); /* call 0x10165d52 */
            ii(0x1015_3eff, 1); push(ebx);                              /* push ebx */
            ii(0x1015_3f00, 1); push(ecx);                              /* push ecx */
            ii(0x1015_3f01, 1); push(edx);                              /* push edx */
            ii(0x1015_3f02, 1); push(esi);                              /* push esi */
            ii(0x1015_3f03, 1); push(edi);                              /* push edi */
            ii(0x1015_3f04, 1); push(ebp);                              /* push ebp */
            ii(0x1015_3f05, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_3f07, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1015_3f0d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_3f10, 7); cmp(memb[ds, 0x101c_947d], 0);          /* cmp byte [0x101c947d], 0x0 */
            ii(0x1015_3f17, 2); if(jz(0x1015_3f20, 7)) goto l_0x1015_3f20; /* jz 0x10153f20 */
            ii(0x1015_3f19, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3f1c, 4); mov(memb[ds, eax + 95], 0);             /* mov byte [eax+0x5f], 0x0 */
        l_0x1015_3f20:
            ii(0x1015_3f20, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3f23, 3); mov(al, memb[ds, eax + 94]);            /* mov al, [eax+0x5e] */
            ii(0x1015_3f26, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3f2b, 3); sar(eax, 3);                            /* sar eax, 0x3 */
            ii(0x1015_3f2e, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1015_3f31, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1015_3f38, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_3f3f, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3f43, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1015_3f46, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3f48, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3f4b, 3); mov(al, memb[ds, eax + 94]);            /* mov al, [eax+0x5e] */
            ii(0x1015_3f4e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_3f53, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1015_3f56, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1015_3f58, 2); if(jg(0x1015_3f83, 0x29)) goto l_0x1015_3f83; /* jg 0x10153f83 */
            ii(0x1015_3f5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3f5d, 4); test(memb[ds, eax + 94], 1);            /* test byte [eax+0x5e], 0x1 */
            ii(0x1015_3f61, 2); if(jz(0x1015_3f81, 0x1e)) goto l_0x1015_3f81; /* jz 0x10153f81 */
            ii(0x1015_3f63, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3f67, 8); movsx(ax, memb[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3f6f, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1015_3f72, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3f76, 8); movsx(ax, memb[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3f7e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1015_3f81:
            ii(0x1015_3f81, 2); jmp(0x1015_3fb0, 0x2d); goto l_0x1015_3fb0; /* jmp 0x10153fb0 */
        l_0x1015_3f83:
            ii(0x1015_3f83, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3f86, 4); test(memb[ds, eax + 94], 1);            /* test byte [eax+0x5e], 0x1 */
            ii(0x1015_3f8a, 2); if(jz(0x1015_3fb0, 0x24)) goto l_0x1015_3fb0; /* jz 0x10153fb0 */
            ii(0x1015_3f8c, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3f90, 8); movsx(ax, memb[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1015_3f98, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1015_3f9b, 3); neg(memd[ss, ebp - 20]);                /* neg dword [ebp-0x14] */
            ii(0x1015_3f9e, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1015_3fa2, 8); movsx(ax, memb[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1015_3faa, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_3fad, 3); neg(memd[ss, ebp - 12]);                /* neg dword [ebp-0xc] */
        l_0x1015_3fb0:
            ii(0x1015_3fb0, 5); cmp(memw[ss, ebp - 20], 0);             /* cmp word [ebp-0x14], 0x0 */
            ii(0x1015_3fb5, 2); if(jnz(0x1015_3fbe, 7)) goto l_0x1015_3fbe; /* jnz 0x10153fbe */
            ii(0x1015_3fb7, 5); cmp(memw[ss, ebp - 12], 0);             /* cmp word [ebp-0xc], 0x0 */
            ii(0x1015_3fbc, 2); if(jz(0x1015_4028, 0x6a)) goto l_0x1015_4028; /* jz 0x10154028 */
        l_0x1015_3fbe:
            ii(0x1015_3fbe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3fc1, 4); cmp(memb[ds, eax + 95], 0);             /* cmp byte [eax+0x5f], 0x0 */
            ii(0x1015_3fc5, 2); if(jnz(0x1015_3fd2, 0xb)) goto l_0x1015_3fd2; /* jnz 0x10153fd2 */
            ii(0x1015_3fc7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_3fc9, 5); mov(al, memb[ds, 0x101c_947c]);         /* mov al, [0x101c947c] */
            ii(0x1015_3fce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_3fd0, 2); if(jnz(0x1015_3fdb, 9)) goto l_0x1015_3fdb; /* jnz 0x10153fdb */
        l_0x1015_3fd2:
            ii(0x1015_3fd2, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_3fd6, 5); jmp(0x1015_4057, 0x7c); goto l_0x1015_4057; /* jmp 0x10154057 */
        l_0x1015_3fdb:
            ii(0x1015_3fdb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3fde, 5); call(0x1014_9fa8, -0xa03b);             /* call 0x10149fa8 */
            ii(0x1015_3fe3, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_3fe7, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1015_3feb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3fee, 5); call(0x1014_9c2f, -0xa3c4);             /* call 0x10149c2f */
            ii(0x1015_3ff3, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1015_3ff6, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_3ff8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_3ffb, 7); sub(memw[ds, eax + 217], dx);           /* sub [eax+0xd9], dx */
            ii(0x1015_4002, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1015_4005, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_4007, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_400a, 7); sub(memw[ds, eax + 219], dx);           /* sub [eax+0xdb], dx */
            ii(0x1015_4011, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_4014, 5); call(0x1014_9cd1, -0xa348);             /* call 0x10149cd1 */
            ii(0x1015_4019, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_401c, 5); call(0x1014_9fa8, -0xa079);             /* call 0x10149fa8 */
            ii(0x1015_4021, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_4024, 4); mov(memb[ds, eax + 95], 1);             /* mov byte [eax+0x5f], 0x1 */
        l_0x1015_4028:
            ii(0x1015_4028, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_402b, 3); mov(dl, memb[ds, eax + 94]);            /* mov dl, [eax+0x5e] */
            ii(0x1015_402e, 2); inc(dl);                                /* inc dl */
            ii(0x1015_4030, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_4033, 3); and(dl, 0x3f);                          /* and dl, 0x3f */
            ii(0x1015_4036, 3); mov(memb[ds, eax + 94], dl);            /* mov [eax+0x5e], dl */
            ii(0x1015_4039, 5); cmp(memw[ss, ebp - 20], 0);             /* cmp word [ebp-0x14], 0x0 */
            ii(0x1015_403e, 2); if(jnz(0x1015_4047, 7)) goto l_0x1015_4047; /* jnz 0x10154047 */
            ii(0x1015_4040, 5); cmp(memw[ss, ebp - 12], 0);             /* cmp word [ebp-0xc], 0x0 */
            ii(0x1015_4045, 2); if(jz(0x1015_404d, 6)) goto l_0x1015_404d; /* jz 0x1015404d */
        l_0x1015_4047:
            ii(0x1015_4047, 4); mov(memb[ss, ebp - 24], 1);             /* mov byte [ebp-0x18], 0x1 */
            ii(0x1015_404b, 2); jmp(0x1015_4051, 4); goto l_0x1015_4051; /* jmp 0x10154051 */
        l_0x1015_404d:
            ii(0x1015_404d, 4); mov(memb[ss, ebp - 24], 0);             /* mov byte [ebp-0x18], 0x0 */
        l_0x1015_4051:
            ii(0x1015_4051, 3); mov(al, memb[ss, ebp - 24]);            /* mov al, [ebp-0x18] */
            ii(0x1015_4054, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
        l_0x1015_4057:
            ii(0x1015_4057, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1015_405a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_405c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_405d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_405e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_405f, 1); pop(edx);                               /* pop edx */
            ii(0x1015_4060, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_4061, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_4062, 1); ret();                                  /* ret */
        }
    }
}
