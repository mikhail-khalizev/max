using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_7083-b8bdc9b")]
        public void Method_1010_7083()
        {
            ii(0x1010_7083, 5); push(0x38);                             /* push 0x38 */
            ii(0x1010_7088, 5); call(Definitions.sys_check_available_stack_size, 0x5_ecc5); /* call 0x10165d52 */
            ii(0x1010_708d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_708e, 1); push(esi);                              /* push esi */
            ii(0x1010_708f, 1); push(edi);                              /* push edi */
            ii(0x1010_7090, 1); push(ebp);                              /* push ebp */
            ii(0x1010_7091, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7093, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1010_7099, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_709c, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1010_709f, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1010_70a2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_70a5, 4); mov(ax, memw[ds, eax + 44]);            /* mov ax, [eax+0x2c] */
            ii(0x1010_70a9, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_70ae, 2); xchg(ah, al);                           /* xchg ah, al */
            ii(0x1010_70b0, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x1010_70b3, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1010_70b6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_70b8, 4); mov(ax, memw[ss, ebp - 16]);            /* mov ax, [ebp-0x10] */
            ii(0x1010_70bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_70be, 2); if(jle(0x1010_70cd, 0xd)) goto l_0x1010_70cd; /* jle 0x101070cd */
            ii(0x1010_70c0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_70c2, 4); mov(ax, memw[ss, ebp - 16]);            /* mov ax, [ebp-0x10] */
            ii(0x1010_70c6, 5); cmp(eax, 0x22e);                        /* cmp eax, 0x22e */
            ii(0x1010_70cb, 2); if(jbe(0x1010_70d2, 5)) goto l_0x1010_70d2; /* jbe 0x101070d2 */
        l_0x1010_70cd:
            ii(0x1010_70cd, 5); jmp(0x1010_7214, 0x142); goto l_0x1010_7214; /* jmp 0x10107214 */
        l_0x1010_70d2:
            ii(0x1010_70d2, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_70d5, 3); add(eax, 0x50);                         /* add eax, 0x50 */
            ii(0x1010_70d8, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1010_70db, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_70df, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_70e2, 6); mov(eax, memd[ds, eax + 0x101c_4130]);  /* mov eax, [eax+0x101c4130] */
            ii(0x1010_70e8, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1010_70eb, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1010_70f0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_70f3, 3); mov(eax, memd[ds, eax + 72]);           /* mov eax, [eax+0x48] */
            ii(0x1010_70f6, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_70f9, 3); mov(edx, memd[ds, edx + 72]);           /* mov edx, [edx+0x48] */
            ii(0x1010_70fc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_70ff, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_7101, 3); mov(memb[ss, ebp - 28], dl);            /* mov [ebp-0x1c], dl */
            ii(0x1010_7104, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_7107, 3); sub(eax, 8);                            /* sub eax, 0x8 */
            ii(0x1010_710a, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1010_710d, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_7111, 2); if(jnz(0x1010_7140, 0x2d)) goto l_0x1010_7140; /* jnz 0x10107140 */
            ii(0x1010_7113, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7115, 4); mov(ax, memw[ss, ebp - 32]);            /* mov ax, [ebp-0x20] */
            ii(0x1010_7119, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_711b, 2); if(jz(0x1010_713b, 0x1e)) goto l_0x1010_713b; /* jz 0x1010713b */
            ii(0x1010_711d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_711f, 3); mov(bl, memb[ss, ebp - 28]);            /* mov bl, [ebp-0x1c] */
            ii(0x1010_7122, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7124, 4); mov(dx, memw[ss, ebp - 32]);            /* mov dx, [ebp-0x20] */
            ii(0x1010_7128, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1010_712b, 5); call(0x1010_7020, -0x110);              /* call 0x10107020 */
            ii(0x1010_7130, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7132, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_7135, 4); cmp(dx, memw[ds, eax + 78]);            /* cmp dx, [eax+0x4e] */
            ii(0x1010_7139, 2); if(jz(0x1010_7140, 5)) goto l_0x1010_7140; /* jz 0x10107140 */
        l_0x1010_713b:
            ii(0x1010_713b, 5); jmp(0x1010_7212, 0xd2); goto l_0x1010_7212; /* jmp 0x10107212 */
        l_0x1010_7140:
            ii(0x1010_7140, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7144, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_7147, 6); inc(memd[ds, eax + 0x101c_4160]);       /* inc dword [eax+0x101c4160] */
            ii(0x1010_714d, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7151, 3); shl(eax, 7);                            /* shl eax, 0x7 */
            ii(0x1010_7154, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7156, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7158, 3); mov(al, memb[ss, ebp - 28]);            /* mov al, [ebp-0x1c] */
            ii(0x1010_715b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_715d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_715f, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1010_7162, 7); mov(memw[ds, edx + 0x101c_4170], ax);   /* mov [edx+0x101c4170], ax */
            ii(0x1010_7169, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1010_716d, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1010_7170, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7174, 3); shl(eax, 8);                            /* shl eax, 0x8 */
            ii(0x1010_7177, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_7179, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_717b, 3); mov(al, memb[ss, ebp - 28]);            /* mov al, [ebp-0x1c] */
            ii(0x1010_717e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_7181, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_7183, 6); mov(edx, memd[ds, edx + 0x101c_4130]);  /* mov edx, [edx+0x101c4130] */
            ii(0x1010_7189, 6); mov(memd[ds, eax + 0x101c_4370], edx);  /* mov [eax+0x101c4370], edx */
            ii(0x1010_718f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7191, 4); mov(ax, memw[ss, ebp - 16]);            /* mov ax, [ebp-0x10] */
            ii(0x1010_7195, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1010_7198, 5); cmp(eax, 0x400);                        /* cmp eax, 0x400 */
            ii(0x1010_719d, 2); if(jle(0x1010_71de, 0x3f)) goto l_0x1010_71de; /* jle 0x101071de */
            ii(0x1010_719f, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_71a4, 3); sub(eax, memd[ss, ebp - 24]);           /* sub eax, [ebp-0x18] */
            ii(0x1010_71a7, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1010_71aa, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_71ac, 4); mov(bx, memw[ss, ebp - 36]);            /* mov bx, [ebp-0x24] */
            ii(0x1010_71b0, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1010_71b3, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_71b7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_71ba, 6); mov(eax, memd[ds, eax + 0x101c_4140]);  /* mov eax, [eax+0x101c4140] */
            ii(0x1010_71c0, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1010_71c3, 5); call(Definitions.sys_memcpy, 0x5_ec83); /* call 0x10165e4b */
            ii(0x1010_71c8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_71ca, 4); mov(ax, memw[ss, ebp - 36]);            /* mov ax, [ebp-0x24] */
            ii(0x1010_71ce, 3); add(memd[ss, ebp - 20], eax);           /* add [ebp-0x14], eax */
            ii(0x1010_71d1, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1010_71d8, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1010_71db, 3); sub(memd[ss, ebp - 16], eax);           /* sub [ebp-0x10], eax */
        l_0x1010_71de:
            ii(0x1010_71de, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_71e0, 4); mov(bx, memw[ss, ebp - 16]);            /* mov bx, [ebp-0x10] */
            ii(0x1010_71e4, 3); mov(edx, memd[ss, ebp - 20]);           /* mov edx, [ebp-0x14] */
            ii(0x1010_71e7, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_71eb, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_71ee, 6); mov(eax, memd[ds, eax + 0x101c_4140]);  /* mov eax, [eax+0x101c4140] */
            ii(0x1010_71f4, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1010_71f7, 5); call(Definitions.sys_memcpy, 0x5_ec4f); /* call 0x10165e4b */
            ii(0x1010_71fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_71fe, 4); mov(dx, memw[ss, ebp - 16]);            /* mov dx, [ebp-0x10] */
            ii(0x1010_7202, 3); add(edx, memd[ss, ebp - 24]);           /* add edx, [ebp-0x18] */
            ii(0x1010_7205, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7209, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_720c, 6); mov(memd[ds, eax + 0x101c_4130], edx);  /* mov [eax+0x101c4130], edx */
        l_0x1010_7212:
            ii(0x1010_7212, 2); jmp(0x1010_721a, 6); goto l_0x1010_721a; /* jmp 0x1010721a */
        l_0x1010_7214:
            ii(0x1010_7214, 6); inc(memd[ds, 0x101c_4db0]);             /* inc dword [0x101c4db0] */
        l_0x1010_721a:
            ii(0x1010_721a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_721c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_721d, 1); pop(edi);                               /* pop edi */
            ii(0x1010_721e, 1); pop(esi);                               /* pop esi */
            ii(0x1010_721f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_7220, 1); ret();                                  /* ret */
        }
    }
}
