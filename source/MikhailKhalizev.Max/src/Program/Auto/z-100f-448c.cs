using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_448c-6a9639d2")]
        public void Method_100f_448c()
        {
            ii(0x100f_448c, 5); push(0x64);                             /* push 0x64 */
            ii(0x100f_4491, 5); call(Definitions.sys_check_available_stack_size, 0x7_18bc); /* call 0x10165d52 */
            ii(0x100f_4496, 1); push(ebx);                              /* push ebx */
            ii(0x100f_4497, 1); push(ecx);                              /* push ecx */
            ii(0x100f_4498, 1); push(edx);                              /* push edx */
            ii(0x100f_4499, 1); push(esi);                              /* push esi */
            ii(0x100f_449a, 1); push(edi);                              /* push edi */
            ii(0x100f_449b, 1); push(ebp);                              /* push ebp */
            ii(0x100f_449c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_449e, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x100f_44a4, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x100f_44a7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_44a9, 5); mov(al, memb[ds, 0x101c_37e4]);         /* mov al, [0x101c37e4] */
            ii(0x100f_44ae, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_44b0, 6); if(jz(0x100f_467c, 0x1c6)) goto l_0x100f_467c; /* jz 0x100f467c */
            ii(0x100f_44b6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_44b8, 5); call(0x100e_883d, -0xbc80);             /* call 0x100e883d */
            ii(0x100f_44bd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_44c0, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100f_44c5, 5); call(Definitions.sys_new, 0x7_1936);    /* call 0x10165e00 */
            ii(0x100f_44ca, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_44cd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_44d0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_44d3, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_44d7, 2); if(jz(0x100f_4510, 0x37)) goto l_0x100f_4510; /* jz 0x100f4510 */
            ii(0x100f_44d9, 5); mov(eax, memd[ds, 0x101c_387f]);        /* mov eax, [0x101c387f] */
            ii(0x100f_44de, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_44e1, 1); push(eax);                              /* push eax */
            ii(0x100f_44e2, 6); mov(ecx, memd[ds, 0x101c_387d]);        /* mov ecx, [0x101c387d] */
            ii(0x100f_44e8, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_44eb, 6); mov(ebx, memd[ds, 0x101c_387b]);        /* mov ebx, [0x101c387b] */
            ii(0x100f_44f1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_44f4, 6); mov(edx, memd[ds, 0x101c_3879]);        /* mov edx, [0x101c3879] */
            ii(0x100f_44fa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_44fd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_4500, 5); call(0x100d_7bdc, -0x1_c929);           /* call 0x100d7bdc */
            ii(0x100f_4505, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_4508, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_450b, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_450e, 2); jmp(0x100f_4516, 0x6); goto l_0x100f_4516; /* jmp 0x100f4516 */
        l_0x100f_4510:
            ii(0x100f_4510, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_4513, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100f_4516:
            ii(0x100f_4516, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_4519, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_451c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_451f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_4522, 5); call(0x100d_7d74, -0x1_c7b3);           /* call 0x100d7d74 */
            ii(0x100f_4527, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4529, 5); mov(al, memb[ds, 0x101c_37e4]);         /* mov al, [0x101c37e4] */
            ii(0x100f_452e, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100f_4531:
            ii(0x100f_4531, 3); dec(memd[ss, ebp - 0x20]);              /* dec dword [ebp-0x20] */
            ii(0x100f_4534, 5); cmp(memw[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x100f_4539, 2); if(jz(0x100f_456e, 0x33)) goto l_0x100f_456e; /* jz 0x100f456e */
            ii(0x100f_453b, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100f_453f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_4542, 6); mov(eax, memd[ds, eax + 0x101c_3853]);  /* mov eax, [eax+0x101c3853] */
            ii(0x100f_4548, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_454b, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100f_454f, 2); if(jz(0x100f_4565, 0x14)) goto l_0x100f_4565; /* jz 0x100f4565 */
            ii(0x100f_4551, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4553, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100f_4556, 5); call(Definitions.my_dtor_d2, -0x2_6023); /* call 0x100ce538 */
            ii(0x100f_455b, 5); call(Definitions.sys_delete, 0x7_1a04); /* call 0x10165f64 */
            ii(0x100f_4560, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_4563, 2); jmp(0x100f_456c, 0x7); goto l_0x100f_456c; /* jmp 0x100f456c */
        l_0x100f_4565:
            ii(0x100f_4565, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x100f_456c:
            ii(0x100f_456c, 2); jmp(0x100f_4531, -0x3d); goto l_0x100f_4531; /* jmp 0x100f4531 */
        l_0x100f_456e:
            ii(0x100f_456e, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_4571, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_4574, 5); call(0x100d_7f6c, -0x1_c60d);           /* call 0x100d7f6c */
            ii(0x100f_4579, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_457c, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100f_457f, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100f_4583, 2); if(jz(0x100f_4599, 0x14)) goto l_0x100f_4599; /* jz 0x100f4599 */
            ii(0x100f_4585, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4587, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100f_458a, 5); call(Definitions.my_dtor_d3, -0x1_c85c); /* call 0x100d7d33 */
            ii(0x100f_458f, 5); call(Definitions.sys_delete, 0x7_19d0); /* call 0x10165f64 */
            ii(0x100f_4594, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_4597, 2); jmp(0x100f_45a0, 0x7); goto l_0x100f_45a0; /* jmp 0x100f45a0 */
        l_0x100f_4599:
            ii(0x100f_4599, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x100f_45a0:
            ii(0x100f_45a0, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_45a5, 5); call(0x100e_883d, -0xbd6d);             /* call 0x100e883d */
            ii(0x100f_45aa, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100f_45ad, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_45b2, 5); call(0x100e_883d, -0xbd7a);             /* call 0x100e883d */
            ii(0x100f_45b7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_45ba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_45bd, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_45bf, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100f_45c2, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100f_45c4, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_45cb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_45ce, 6); mov(edx, memd[ds, 0x101c_38ec]);        /* mov edx, [0x101c38ec] */
            ii(0x100f_45d4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_45d6, 3); mov(memd[ss, ebp - 0x44], edx);         /* mov [ebp-0x44], edx */
            ii(0x100f_45d9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_45dc, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_45df, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100f_45e2, 3); sub(eax, memd[ds, edx + 0x4]);          /* sub eax, [edx+0x4] */
            ii(0x100f_45e5, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_45ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_45ef, 6); mov(edx, memd[ds, 0x101c_38f0]);        /* mov edx, [0x101c38f0] */
            ii(0x100f_45f5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_45f7, 3); mov(memd[ss, ebp - 0x40], edx);         /* mov [ebp-0x40], edx */
            ii(0x100f_45fa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_45fd, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_4600, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100f_4603, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100f_4605, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_460c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_460f, 3); mov(edx, memd[ss, ebp - 0x44]);         /* mov edx, [ebp-0x44] */
            ii(0x100f_4612, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_4614, 3); mov(memd[ss, ebp - 0x3c], edx);         /* mov [ebp-0x3c], edx */
            ii(0x100f_4617, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_461a, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100f_461d, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x100f_4620, 3); sub(eax, memd[ds, edx + 0x4]);          /* sub eax, [edx+0x4] */
            ii(0x100f_4623, 7); imul(eax, memd[ds, 0x101c_38c4]);       /* imul eax, [0x101c38c4] */
            ii(0x100f_462a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_462d, 3); mov(edx, memd[ss, ebp - 0x40]);         /* mov edx, [ebp-0x40] */
            ii(0x100f_4630, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_4632, 3); mov(memd[ss, ebp - 0x38], edx);         /* mov [ebp-0x38], edx */
            ii(0x100f_4635, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x100f_4638, 5); call(0x100f_f562, 0xaf25);              /* call 0x100ff562 */
            ii(0x100f_463d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_4640, 7); mov(memd[ds, eax + 0xc], 0xffff_ffff);  /* mov dword [eax+0xc], 0xffffffff */
            ii(0x100f_4647, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_464a, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x100f_464d, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_4650, 3); mov(memd[ds, edx + 0x8], eax);          /* mov [edx+0x8], eax */
            ii(0x100f_4653, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_4656, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100f_4659, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_465c, 3); mov(memd[ds, edx + 0x4], eax);          /* mov [edx+0x4], eax */
            ii(0x100f_465f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_4662, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x100f_4665, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_4668, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x100f_466a, 7); mov(memb[ds, 0x101c_37e4], 0);          /* mov byte [0x101c37e4], 0x0 */
            ii(0x100f_4671, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_4675, 2); if(jz(0x100f_467c, 0x5)) goto l_0x100f_467c; /* jz 0x100f467c */
            ii(0x100f_4677, 5); call(0x100e_a903, -0x9d79);             /* call 0x100ea903 */
        l_0x100f_467c:
            ii(0x100f_467c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_467e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_467f, 1); pop(edi);                               /* pop edi */
            ii(0x100f_4680, 1); pop(esi);                               /* pop esi */
            ii(0x100f_4681, 1); pop(edx);                               /* pop edx */
            ii(0x100f_4682, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_4683, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_4684, 1); ret();                                  /* ret */
        }
    }
}
